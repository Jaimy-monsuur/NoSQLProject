
namespace GardenGroupUI
{
    partial class User_Management
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
            this.LVTickets = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Subject = new System.Windows.Forms.ColumnHeader();
            this.BTNAddUser = new System.Windows.Forms.Button();
            this.TBXfilter = new System.Windows.Forms.TextBox();
            this.LblTicket = new System.Windows.Forms.Label();
            this.PNLmain = new System.Windows.Forms.Panel();
            this.LBLLicense = new System.Windows.Forms.Label();
            this.LBLnodesk = new System.Windows.Forms.Label();
            this.PBOX = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PNLmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVTickets
            // 
            this.LVTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Subject});
            this.LVTickets.HideSelection = false;
            this.LVTickets.Location = new System.Drawing.Point(109, 211);
            this.LVTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LVTickets.Name = "LVTickets";
            this.LVTickets.Size = new System.Drawing.Size(899, 276);
            this.LVTickets.TabIndex = 10;
            this.LVTickets.UseCompatibleStateImageBehavior = false;
            // 
            // Id
            // 
            this.Id.Width = 40;
            // 
            // BTNAddUser
            // 
            this.BTNAddUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTNAddUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNAddUser.Location = new System.Drawing.Point(858, 163);
            this.BTNAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNAddUser.Name = "BTNAddUser";
            this.BTNAddUser.Size = new System.Drawing.Size(150, 27);
            this.BTNAddUser.TabIndex = 9;
            this.BTNAddUser.Text = "Create user";
            this.BTNAddUser.UseVisualStyleBackColor = false;
            // 
            // TBXfilter
            // 
            this.TBXfilter.Location = new System.Drawing.Point(109, 170);
            this.TBXfilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBXfilter.Name = "TBXfilter";
            this.TBXfilter.Size = new System.Drawing.Size(286, 23);
            this.TBXfilter.TabIndex = 8;
            this.TBXfilter.TabStop = false;
            // 
            // LblTicket
            // 
            this.LblTicket.AutoSize = true;
            this.LblTicket.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTicket.Location = new System.Drawing.Point(109, 128);
            this.LblTicket.Name = "LblTicket";
            this.LblTicket.Size = new System.Drawing.Size(202, 32);
            this.LblTicket.TabIndex = 7;
            this.LblTicket.Text = "Overview tickets";
            // 
            // PNLmain
            // 
            this.PNLmain.Controls.Add(this.LBLLicense);
            this.PNLmain.Controls.Add(this.LBLnodesk);
            this.PNLmain.Controls.Add(this.PBOX);
            this.PNLmain.Controls.Add(this.Menu);
            this.PNLmain.Location = new System.Drawing.Point(1, 18);
            this.PNLmain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PNLmain.Name = "PNLmain";
            this.PNLmain.Size = new System.Drawing.Size(1102, 93);
            this.PNLmain.TabIndex = 6;
            // 
            // LBLLicense
            // 
            this.LBLLicense.AutoSize = true;
            this.LBLLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLLicense.Location = new System.Drawing.Point(829, 44);
            this.LBLLicense.Name = "LBLLicense";
            this.LBLLicense.Size = new System.Drawing.Size(242, 21);
            this.LBLLicense.TabIndex = 2;
            this.LBLLicense.Text = "Licensed to: The Garden Group";
            // 
            // LBLnodesk
            // 
            this.LBLnodesk.AutoSize = true;
            this.LBLnodesk.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLnodesk.Location = new System.Drawing.Point(956, 7);
            this.LBLnodesk.Name = "LBLnodesk";
            this.LBLnodesk.Size = new System.Drawing.Size(128, 41);
            this.LBLnodesk.TabIndex = 1;
            this.LBLnodesk.Text = "NoDesk";
            // 
            // PBOX
            // 
            this.PBOX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PBOX.Location = new System.Drawing.Point(10, 9);
            this.PBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBOX.Name = "PBOX";
            this.PBOX.Size = new System.Drawing.Size(148, 58);
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
            this.Menu.Location = new System.Drawing.Point(0, 65);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(1102, 28);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStripUser";
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
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.LVTickets);
            this.Controls.Add(this.BTNAddUser);
            this.Controls.Add(this.TBXfilter);
            this.Controls.Add(this.LblTicket);
            this.Controls.Add(this.PNLmain);
            this.Name = "User_Management";
            this.Text = "User_Management";
            this.PNLmain.ResumeLayout(false);
            this.PNLmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVTickets;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.Button BTNAddUser;
        private System.Windows.Forms.TextBox TBXfilter;
        private System.Windows.Forms.Label LblTicket;
        private System.Windows.Forms.Panel PNLmain;
        private System.Windows.Forms.Label LBLLicense;
        private System.Windows.Forms.Label LBLnodesk;
        private System.Windows.Forms.PictureBox PBOX;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
    }
}