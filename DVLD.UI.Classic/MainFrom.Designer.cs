namespace DVLD.UI.Classic
{
    partial class frmMain
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsddbtnApplications = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsddbtnPeople = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsddbtnDrivers = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsddbtnUsers = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbtnAccountSettings = new System.Windows.Forms.ToolStripButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbtnApplications,
            this.tsddbtnPeople,
            this.tsddbtnDrivers,
            this.tsddbtnUsers,
            this.tsbtnAccountSettings});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1062, 71);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsddbtnApplications
            // 
            this.tsddbtnApplications.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsddbtnApplications.Image = global::DVLD.UI.Classic.Properties.Resources.tsApplications_64x64;
            this.tsddbtnApplications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtnApplications.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsddbtnApplications.Name = "tsddbtnApplications";
            this.tsddbtnApplications.Size = new System.Drawing.Size(162, 68);
            this.tsddbtnApplications.Text = "Applications";
            // 
            // tsddbtnPeople
            // 
            this.tsddbtnPeople.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsddbtnPeople.Image = global::DVLD.UI.Classic.Properties.Resources.tsPeople_64x64;
            this.tsddbtnPeople.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtnPeople.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsddbtnPeople.Name = "tsddbtnPeople";
            this.tsddbtnPeople.Size = new System.Drawing.Size(127, 68);
            this.tsddbtnPeople.Text = "People";
            this.tsddbtnPeople.Click += new System.EventHandler(this.tsddbtnPeople_Click);
            // 
            // tsddbtnDrivers
            // 
            this.tsddbtnDrivers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsddbtnDrivers.Image = global::DVLD.UI.Classic.Properties.Resources.tsDrivers_64x64;
            this.tsddbtnDrivers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtnDrivers.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsddbtnDrivers.Name = "tsddbtnDrivers";
            this.tsddbtnDrivers.Size = new System.Drawing.Size(129, 68);
            this.tsddbtnDrivers.Text = "Drivers";
            // 
            // tsddbtnUsers
            // 
            this.tsddbtnUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsddbtnUsers.Image = global::DVLD.UI.Classic.Properties.Resources.tsUsers_64x64;
            this.tsddbtnUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtnUsers.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsddbtnUsers.Name = "tsddbtnUsers";
            this.tsddbtnUsers.Size = new System.Drawing.Size(118, 68);
            this.tsddbtnUsers.Text = "Users";
            // 
            // tsbtnAccountSettings
            // 
            this.tsbtnAccountSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsbtnAccountSettings.Image = global::DVLD.UI.Classic.Properties.Resources.tsAccount_settings_64x64;
            this.tsbtnAccountSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAccountSettings.Name = "tsbtnAccountSettings";
            this.tsbtnAccountSettings.Size = new System.Drawing.Size(176, 68);
            this.tsbtnAccountSettings.Text = "AccountSettings";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 71);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1062, 552);
            this.pnlContainer.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 623);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmMain";
            this.Text = "Driver and Vehicle Licensing Department";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtnApplications;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtnPeople;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtnDrivers;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtnUsers;
        private System.Windows.Forms.ToolStripButton tsbtnAccountSettings;
        private System.Windows.Forms.Panel pnlContainer;
    }
}

