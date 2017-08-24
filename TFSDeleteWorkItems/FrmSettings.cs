using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFSDeleteWorkItems
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save settings
            Settings.SaveSettings(cboEnableBulkConfirm.Checked,cboEnableSingleConfirm.Checked);
            Settings.LoadSettings();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            cboEnableBulkConfirm.Checked = Settings.EnabledConfirmationForBulkDelete;
            cboEnableSingleConfirm.Checked = Settings.EnabledConfirmationForSinglekDelete;
        }
    }
}
