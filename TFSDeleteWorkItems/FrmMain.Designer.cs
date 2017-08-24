namespace TFSDeleteWorkItems
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnMyQueries = new System.Windows.Forms.RadioButton();
            this.rbtnWorkItemId = new System.Windows.Forms.RadioButton();
            this.txtWorkItemId = new System.Windows.Forms.TextBox();
            this.menMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectProject = new System.Windows.Forms.Button();
            this.lbxQueries = new System.Windows.Forms.ListBox();
            this.dgvWorkItemsQueryResult = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbo = new System.Windows.Forms.CheckBox();
            this.menMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkItemsQueryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnMyQueries
            // 
            this.rbtnMyQueries.AutoSize = true;
            this.rbtnMyQueries.Location = new System.Drawing.Point(14, 79);
            this.rbtnMyQueries.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMyQueries.Name = "rbtnMyQueries";
            this.rbtnMyQueries.Size = new System.Drawing.Size(78, 17);
            this.rbtnMyQueries.TabIndex = 22;
            this.rbtnMyQueries.Text = "My Queries";
            this.rbtnMyQueries.UseVisualStyleBackColor = true;
            this.rbtnMyQueries.CheckedChanged += new System.EventHandler(this.rbtnMyQueries_CheckedChanged);
            // 
            // rbtnWorkItemId
            // 
            this.rbtnWorkItemId.AutoSize = true;
            this.rbtnWorkItemId.Checked = true;
            this.rbtnWorkItemId.Location = new System.Drawing.Point(14, 51);
            this.rbtnWorkItemId.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnWorkItemId.Name = "rbtnWorkItemId";
            this.rbtnWorkItemId.Size = new System.Drawing.Size(53, 17);
            this.rbtnWorkItemId.TabIndex = 23;
            this.rbtnWorkItemId.TabStop = true;
            this.rbtnWorkItemId.Text = "WI ID";
            this.rbtnWorkItemId.UseVisualStyleBackColor = true;
            this.rbtnWorkItemId.CheckedChanged += new System.EventHandler(this.rbtnWorkItemId_CheckedChanged);
            // 
            // txtWorkItemId
            // 
            this.txtWorkItemId.Location = new System.Drawing.Point(99, 51);
            this.txtWorkItemId.Margin = new System.Windows.Forms.Padding(2);
            this.txtWorkItemId.MaxLength = 8;
            this.txtWorkItemId.Name = "txtWorkItemId";
            this.txtWorkItemId.Size = new System.Drawing.Size(465, 20);
            this.txtWorkItemId.TabIndex = 1;
            this.txtWorkItemId.TextChanged += new System.EventHandler(this.txtWorkItemId_TextChanged);
            this.txtWorkItemId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkItemId_KeyDown);
            this.txtWorkItemId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWorkItemId_KeyPress);
            // 
            // menMain
            // 
            this.menMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menMain.Location = new System.Drawing.Point(0, 0);
            this.menMain.Name = "menMain";
            this.menMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menMain.Size = new System.Drawing.Size(574, 24);
            this.menMain.TabIndex = 26;
            this.menMain.Text = "menMain";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Main";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem.Text = "Help and About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnSelectProject
            // 
            this.btnSelectProject.Location = new System.Drawing.Point(451, 23);
            this.btnSelectProject.Name = "btnSelectProject";
            this.btnSelectProject.Size = new System.Drawing.Size(113, 23);
            this.btnSelectProject.TabIndex = 27;
            this.btnSelectProject.Text = "Connect to Project";
            this.btnSelectProject.UseVisualStyleBackColor = true;
            this.btnSelectProject.Click += new System.EventHandler(this.btnSelectProject_Click);
            // 
            // lbxQueries
            // 
            this.lbxQueries.FormattingEnabled = true;
            this.lbxQueries.Location = new System.Drawing.Point(99, 79);
            this.lbxQueries.Name = "lbxQueries";
            this.lbxQueries.Size = new System.Drawing.Size(465, 108);
            this.lbxQueries.TabIndex = 28;
            this.lbxQueries.SelectedIndexChanged += new System.EventHandler(this.lbxQueries_SelectedIndexChanged);
            this.lbxQueries.DoubleClick += new System.EventHandler(this.lbxQueries_DoubleClick);
            // 
            // dgvWorkItemsQueryResult
            // 
            this.dgvWorkItemsQueryResult.AllowUserToDeleteRows = false;
            this.dgvWorkItemsQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkItemsQueryResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Type});
            this.dgvWorkItemsQueryResult.Location = new System.Drawing.Point(5, 195);
            this.dgvWorkItemsQueryResult.Name = "dgvWorkItemsQueryResult";
            this.dgvWorkItemsQueryResult.ReadOnly = true;
            this.dgvWorkItemsQueryResult.RowHeadersVisible = false;
            this.dgvWorkItemsQueryResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkItemsQueryResult.Size = new System.Drawing.Size(559, 150);
            this.dgvWorkItemsQueryResult.TabIndex = 29;
            this.dgvWorkItemsQueryResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkItemsQueryResult_CellContentClick);
            this.dgvWorkItemsQueryResult.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkItemsQueryResult_CellContentDoubleClick);
            this.dgvWorkItemsQueryResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkItemsQueryResult_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Visible = false;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
            // 
            // rtxtLog
            // 
            this.rtxtLog.Location = new System.Drawing.Point(5, 377);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Size = new System.Drawing.Size(559, 102);
            this.rtxtLog.TabIndex = 30;
            this.rtxtLog.Text = "";
            this.rtxtLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtLog_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(315, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(485, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbo
            // 
            this.cbo.AutoSize = true;
            this.cbo.Location = new System.Drawing.Point(5, 348);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(70, 17);
            this.cbo.TabIndex = 33;
            this.cbo.Text = "Select All";
            this.cbo.UseVisualStyleBackColor = true;
            this.cbo.CheckedChanged += new System.EventHandler(this.cbo_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 484);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.dgvWorkItemsQueryResult);
            this.Controls.Add(this.lbxQueries);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelectProject);
            this.Controls.Add(this.menMain);
            this.Controls.Add(this.txtWorkItemId);
            this.Controls.Add(this.rbtnWorkItemId);
            this.Controls.Add(this.rbtnMyQueries);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "Delete TFS Work-Items Tool (Beta) [v1.0.0.38195]";
            this.menMain.ResumeLayout(false);
            this.menMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkItemsQueryResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnMyQueries;
        private System.Windows.Forms.RadioButton rbtnWorkItemId;
        private System.Windows.Forms.TextBox txtWorkItemId;
        private System.Windows.Forms.MenuStrip menMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnSelectProject;
        private System.Windows.Forms.ListBox lbxQueries;
        private System.Windows.Forms.DataGridView dgvWorkItemsQueryResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbo;
    }
}