﻿
namespace GardenGroupUI
{
    partial class Incident_Management
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
            this.PNLmain = new System.Windows.Forms.Panel();
            this.PBOX = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBLnodesk = new System.Windows.Forms.Label();
            this.LBLLicense = new System.Windows.Forms.Label();
            this.PNLmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNLmain
            // 
            this.PNLmain.Controls.Add(this.LBLLicense);
            this.PNLmain.Controls.Add(this.LBLnodesk);
            this.PNLmain.Controls.Add(this.PBOX);
            this.PNLmain.Controls.Add(this.Menu);
            this.PNLmain.Location = new System.Drawing.Point(0, 0);
            this.PNLmain.Name = "PNLmain";
            this.PNLmain.Size = new System.Drawing.Size(1260, 124);
            this.PNLmain.TabIndex = 0;
            this.PNLmain.Paint += new System.Windows.Forms.PaintEventHandler(this.PNLmain_Paint);
            // 
            // PBOX
            // 
            this.PBOX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PBOX.Location = new System.Drawing.Point(12, 12);
            this.PBOX.Name = "PBOX";
            this.PBOX.Size = new System.Drawing.Size(169, 77);
            this.PBOX.TabIndex = 0;
            this.PBOX.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.incidentManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 96);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1260, 28);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.menuStrip1_Paint);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.AutoSize = false;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // incidentManagementToolStripMenuItem
            // 
            this.incidentManagementToolStripMenuItem.AutoSize = false;
            this.incidentManagementToolStripMenuItem.Name = "incidentManagementToolStripMenuItem";
            this.incidentManagementToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.incidentManagementToolStripMenuItem.Text = "Incident management";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.AutoSize = false;
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.userManagementToolStripMenuItem.Text = "User management";
            // 
            // LBLnodesk
            // 
            this.LBLnodesk.AutoSize = true;
            this.LBLnodesk.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLnodesk.Location = new System.Drawing.Point(1092, 9);
            this.LBLnodesk.Name = "LBLnodesk";
            this.LBLnodesk.Size = new System.Drawing.Size(158, 50);
            this.LBLnodesk.TabIndex = 1;
            this.LBLnodesk.Text = "NoDesk";
            // 
            // LBLLicense
            // 
            this.LBLLicense.AutoSize = true;
            this.LBLLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLLicense.Location = new System.Drawing.Point(965, 59);
            this.LBLLicense.Name = "LBLLicense";
            this.LBLLicense.Size = new System.Drawing.Size(130, 28);
            this.LBLLicense.TabIndex = 2;
            this.LBLLicense.Text = "Licensed to: ";
            // 
            // Incident_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.PNLmain);
            this.MainMenuStrip = this.Menu;
            this.Name = "Incident_Management";
            this.Text = "Incident Management";
            this.Load += new System.EventHandler(this.Incident_Management_Load);
            this.PNLmain.ResumeLayout(false);
            this.PNLmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNLmain;
        private System.Windows.Forms.PictureBox PBOX;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.Label LBLLicense;
        private System.Windows.Forms.Label LBLnodesk;
    }
}