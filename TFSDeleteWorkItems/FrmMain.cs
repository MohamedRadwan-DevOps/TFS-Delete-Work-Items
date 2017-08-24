using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Server;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace TFSDeleteWorkItems
{
    public partial class FrmMain : Form
    {
        private QueryFolder _myQueryFolder;
        private WorkItemStore _workItemStore;
        //private TfsTeamProjectCollection tfsTeamProjectCollection;
        //private ProjectInfo _projectInfo;
        private Project _tfsProject;
        private bool _deleting = false;
        private bool _cancelDelete = false;
        public FrmMain()
        {
            
            Settings.LoadSettings();
            
            InitializeComponent();
            lbxQueries.Enabled = rbtnMyQueries.Checked;
        }

        private void rbtnWorkItemId_CheckedChanged(object sender, EventArgs e)
        {
            lbxQueries.Enabled = rbtnMyQueries.Checked;
        }

        private void btnSelectProject_Click(object sender, EventArgs e)
        {

            var tfsPp = new TeamProjectPicker(TeamProjectPickerMode.SingleProject, false, new UICredentialsProvider());
            DialogResult result = tfsPp.ShowDialog();
            if (result == DialogResult.OK && tfsPp.SelectedProjects != null && tfsPp.SelectedProjects.FirstOrDefault() != null)
            {
                ClearExisting();
                rtxtLog.AppendTextWithNewLine("Connected to " + tfsPp.SelectedTeamProjectCollection, Color.Green);
                rtxtLog.AppendTextWithNewLine("Connected to " + tfsPp.SelectedProjects.FirstOrDefault().Name, Color.Green);
                try
                {
                    _workItemStore = (WorkItemStore)tfsPp.SelectedTeamProjectCollection.GetService(typeof(WorkItemStore));
                    ProjectInfo firstOrDefault = tfsPp.SelectedProjects.FirstOrDefault();
                    if (firstOrDefault != null && _workItemStore != null)
                    {
                        _tfsProject = _workItemStore.Projects[firstOrDefault.Name];
                    }
                    QueryHierarchy queryHierarchy = _tfsProject.QueryHierarchy; // if it's null, check your permission
                    var queryFolder = queryHierarchy as QueryFolder;
                    QueryItem myQueryItem = queryFolder.FirstOrDefault();
                    _myQueryFolder = myQueryItem as QueryFolder;
                    if (_myQueryFolder != null && _myQueryFolder.Count > 0)
                    {
                        lbxQueries.Items.Clear();
                        foreach (var item in _myQueryFolder)
                        {
                            lbxQueries.Items.Add(item.Name);
                        }
                        rtxtLog.AppendTextWithNewLine("Retrieved " + _myQueryFolder.Count + " Queries From My Queries Folder", Color.Green);
                        return;
                    }
                    rtxtLog.AppendTextWithNewLine("No Queries in My Queries Folder", Color.DarkOrange);
                }
                catch (Exception exception)
                {
                    rtxtLog.AppendTextWithNewLine(Utilities.ReadException(exception), Color.Red);
                }
            }

        }

        private void ClearExisting()
        {
            lbxQueries.Items.Clear();
            rtxtLog.Clear();
            _workItemStore = null;
            _myQueryFolder = null;
            _tfsProject = null;
            dgvWorkItemsQueryResult.DataSource = null;
            txtWorkItemId.Text = string.Empty;
            

        }

        private void lbxQueries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxQueries_DoubleClick(object sender, EventArgs e)
        {
            cbo.Checked = false;
            rtxtLog.AppendTextWithNewLine("Trying to retrieve Work-items ......................", Color.Green);
            try
            {
                // Get the query
                var selectedQuery = _myQueryFolder.FirstOrDefault(q => q.Name == lbxQueries.SelectedItem.ToString()) as QueryDefinition;

                // Run the query
                if (selectedQuery != null && selectedQuery.QueryType == QueryType.List)
                {
                    var query = new Query(_workItemStore, selectedQuery.QueryText, GetParamsDictionary());

                    // Bind flat query reuslt only
                    var workItemCollection = query.RunQuery();
                    var workItemsDataSource = new List<object>();

                    foreach (WorkItem workItem in workItemCollection)
                    {
                        workItemsDataSource.Add(new { ID = workItem.Id, Type = workItem.Type.Name, workItem.Title, workItem.State, IterationPath = workItem.Fields["Iteration Path"].Value, workItem.History });

                    }
                    dgvWorkItemsQueryResult.DataSource = workItemsDataSource;
                    rtxtLog.AppendTextWithNewLine("Retrieved " + workItemCollection.Count + " Work-Items From Query: " + selectedQuery.Name, Color.Green);

                }
                else
                {
                    MessageBox.Show("Please Select a Flat Query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtxtLog.AppendTextWithNewLine("This is not a Flat Query", Color.Red);

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(Utilities.ReadException(exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtLog.AppendTextWithNewLine(Utilities.ReadException(exception), Color.Red);
            }
        }
        private IDictionary GetParamsDictionary()
        {
            return new Dictionary<string, string>
                {
                    { "project", _tfsProject.Name },
                    { "me", string.Empty } 
                };
        }

        private void rbtnMyQueries_CheckedChanged(object sender, EventArgs e)
        {
            txtWorkItemId.Enabled = rbtnWorkItemId.Checked;
        }



        private void rtxtLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtWorkItemId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWorkItemId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtWorkItemId_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return) && ((TextBox)sender).Text != string.Empty)
            {
                try
                {
                    var workItemId = int.Parse(((TextBox)sender).Text);
                    var workItem = _workItemStore.GetWorkItem(workItemId);
                    if (workItem != null)
                    {
                        rtxtLog.AppendText("Retrived Work-Item ID: " + workItem.Id + " From Project: " + workItem.Project.Name, Color.Green);
                        rtxtLog.AppendText(Environment.NewLine);
                        dgvWorkItemsQueryResult.DataSource = new List<object>
                        {
                            new
                            {
                                ID = workItem.Id,
                                Type = workItem.Type.Name,
                                workItem.Title,
                                workItem.State,
                                IterationPath = workItem.Fields["Iteration Path"].Value,
                                workItem.History
                            }
                        };
                    }
                }
                catch (Exception exception)
                {
                    rtxtLog.AppendTextWithNewLine(Utilities.ReadException(exception), Color.Red);

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _deleting = true;
            var bulkDeleteDialogResult = DialogResult.Cancel;
            var singleDeleteDialogResult = DialogResult.Cancel;
            if (Settings.EnabledConfirmationForBulkDelete)
            {
                bulkDeleteDialogResult = MessageBox.Show("Are You Sure You Want to Delete (" + dgvWorkItemsQueryResult.SelectedRows.Count + ") Work-items", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            }
            if ((Settings.EnabledConfirmationForBulkDelete && bulkDeleteDialogResult == DialogResult.OK) || (!Settings.EnabledConfirmationForBulkDelete))
            {
                foreach (DataGridViewRow selectedRow in dgvWorkItemsQueryResult.SelectedRows)
                {
                    if (Settings.EnabledConfirmationForSinglekDelete)
                    {
                        singleDeleteDialogResult = MessageBox.Show("Are You Sure You Want to Delete The following Work-item:" +Environment.NewLine+ "ID: " + selectedRow.Cells[3].FormattedValue +Environment.NewLine+ "Type: " + selectedRow.Cells[4].FormattedValue + Environment.NewLine + "Title: " + selectedRow.Cells[5].FormattedValue, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    }
                    if ((Settings.EnabledConfirmationForSinglekDelete && singleDeleteDialogResult == DialogResult.OK) || (!Settings.EnabledConfirmationForSinglekDelete))
                    {
                        //_workItemStore.DestroyWorkItems()
                        if (_cancelDelete)
                            return;
                        try
                        {
                            //MessageBox.Show(selectedRow.Cells[3].FormattedValue.ToString());
                            _workItemStore.DestroyWorkItems(new List<int> { int.Parse(selectedRow.Cells[3].FormattedValue.ToString()) }).ToList();
                            rtxtLog.AppendText("Deleteing The following Work-item:" +Environment.NewLine+ "ID: " + selectedRow.Cells[3].FormattedValue +Environment.NewLine+ "Type: " + selectedRow.Cells[4].FormattedValue + Environment.NewLine + "Title: " + selectedRow.Cells[5].FormattedValue, Color.DarkOrange);
                            rtxtLog.AppendText(Environment.NewLine);
                        }
                        catch (Exception exception)
                        {
                            rtxtLog.AppendTextWithNewLine(Utilities.ReadException(exception), Color.Red);
                        }
                    }
                }
            }
            _deleting = false;
            _cancelDelete = false;

        }

        private void dgvWorkItemsQueryResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dgvWorkItemsQueryResult_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvWorkItemsQueryResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //_workItemStore.DestroyWorkItems()
            btnDelete_Click(btnDelete,new EventArgs());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_deleting)
            {
                _cancelDelete = true;
                rtxtLog.AppendText("Deleting canceled ", Color.Green);
                rtxtLog.AppendText(Environment.NewLine);
            }
        }

        private void cbo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbo.Checked)
            {
                dgvWorkItemsQueryResult.SelectAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ke = new KeyEventArgs(Keys.Return);
            txtWorkItemId_KeyDown(txtWorkItemId,ke);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout=new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings=new FrmSettings();
            frmSettings.ShowDialog();
        }


    }
}
