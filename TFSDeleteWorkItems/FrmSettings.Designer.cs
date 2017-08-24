namespace TFSDeleteWorkItems
{
    partial class FrmSettings
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
            this.cboEnableBulkConfirm = new System.Windows.Forms.CheckBox();
            this.cboEnableSingleConfirm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cboEnableBulkConfirm
            // 
            this.cboEnableBulkConfirm.AutoSize = true;
            this.cboEnableBulkConfirm.Location = new System.Drawing.Point(12, 12);
            this.cboEnableBulkConfirm.Name = "cboEnableBulkConfirm";
            this.cboEnableBulkConfirm.Size = new System.Drawing.Size(155, 17);
            this.cboEnableBulkConfirm.TabIndex = 0;
            this.cboEnableBulkConfirm.Text = "Enable Bulk Delete Confirm";
            this.cboEnableBulkConfirm.UseVisualStyleBackColor = true;
            // 
            // cboEnableSingleConfirm
            // 
            this.cboEnableSingleConfirm.AutoSize = true;
            this.cboEnableSingleConfirm.Location = new System.Drawing.Point(12, 35);
            this.cboEnableSingleConfirm.Name = "cboEnableSingleConfirm";
            this.cboEnableSingleConfirm.Size = new System.Drawing.Size(163, 17);
            this.cboEnableSingleConfirm.TabIndex = 1;
            this.cboEnableSingleConfirm.Text = "Enable Single Delete Confirm";
            this.cboEnableSingleConfirm.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cboEnableSingleConfirm);
            this.Controls.Add(this.cboEnableBulkConfirm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cboEnableBulkConfirm;
        private System.Windows.Forms.CheckBox cboEnableSingleConfirm;
    }
}