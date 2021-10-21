
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PNLmain = new System.Windows.Forms.Panel();
            this.Btn_logOut = new System.Windows.Forms.Button();
            this.LBLnodesk = new System.Windows.Forms.Label();
            this.LBLLicense = new System.Windows.Forms.Label();
            this.PBOX = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTicket = new System.Windows.Forms.Label();
            this.BTNaddTicket = new System.Windows.Forms.Button();
            this.LVTickets = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Subject = new System.Windows.Forms.ColumnHeader();
            this.DGV_Selected = new System.Windows.Forms.DataGridView();
            this.LBL_ticket = new System.Windows.Forms.Label();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.BTN_TransferTicket = new System.Windows.Forms.Button();
            this.BTN_RemoveTicket = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LBL_status = new System.Windows.Forms.Label();
            this.BTNupdate = new System.Windows.Forms.Button();
            this.Rbtn_LowToHigh = new System.Windows.Forms.RadioButton();
            this.Rbtn_HightToLow = new System.Windows.Forms.RadioButton();
            this.PNLmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Selected)).BeginInit();
            this.SuspendLayout();
            // 
            // PNLmain
            // 
            this.PNLmain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLmain.AutoSize = true;
            this.PNLmain.BackColor = System.Drawing.Color.DarkCyan;
            this.PNLmain.Controls.Add(this.Btn_logOut);
            this.PNLmain.Controls.Add(this.LBLnodesk);
            this.PNLmain.Controls.Add(this.LBLLicense);
            this.PNLmain.Controls.Add(this.PBOX);
            this.PNLmain.Controls.Add(this.Menu);
            this.PNLmain.Location = new System.Drawing.Point(0, 0);
            this.PNLmain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PNLmain.Name = "PNLmain";
            this.PNLmain.Size = new System.Drawing.Size(1266, 111);
            this.PNLmain.TabIndex = 0;
            // 
            // Btn_logOut
            // 
            this.Btn_logOut.AutoSize = true;
            this.Btn_logOut.BackColor = System.Drawing.Color.Teal;
            this.Btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_logOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_logOut.Location = new System.Drawing.Point(1130, 71);
            this.Btn_logOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_logOut.Name = "Btn_logOut";
            this.Btn_logOut.Size = new System.Drawing.Size(122, 29);
            this.Btn_logOut.TabIndex = 28;
            this.Btn_logOut.Text = "Log Out";
            this.Btn_logOut.UseVisualStyleBackColor = false;
            this.Btn_logOut.Click += new System.EventHandler(this.Btn_logOut_Click);
            // 
            // LBLnodesk
            // 
            this.LBLnodesk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLnodesk.AutoSize = true;
            this.LBLnodesk.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLnodesk.Location = new System.Drawing.Point(1124, 7);
            this.LBLnodesk.Name = "LBLnodesk";
            this.LBLnodesk.Size = new System.Drawing.Size(128, 41);
            this.LBLnodesk.TabIndex = 1;
            this.LBLnodesk.Text = "NoDesk";
            // 
            // LBLLicense
            // 
            this.LBLLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLLicense.AutoSize = true;
            this.LBLLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLLicense.Location = new System.Drawing.Point(1010, 48);
            this.LBLLicense.Name = "LBLLicense";
            this.LBLLicense.Size = new System.Drawing.Size(242, 21);
            this.LBLLicense.TabIndex = 2;
            this.LBLLicense.Text = "Licensed to: The Garden Group";
            // 
            // PBOX
            // 
            this.PBOX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PBOX.Image = global::GardenGroupUI.Properties.Resources.GardenGourp;
            this.PBOX.Location = new System.Drawing.Point(10, 9);
            this.PBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBOX.Name = "PBOX";
            this.PBOX.Size = new System.Drawing.Size(162, 72);
            this.PBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBOX.TabIndex = 0;
            this.PBOX.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.DarkCyan;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.incidentManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 83);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(1266, 28);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.AutoSize = false;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
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
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // LblTicket
            // 
            this.LblTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTicket.AutoSize = true;
            this.LblTicket.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTicket.Location = new System.Drawing.Point(41, 113);
            this.LblTicket.Name = "LblTicket";
            this.LblTicket.Size = new System.Drawing.Size(202, 32);
            this.LblTicket.TabIndex = 2;
            this.LblTicket.Text = "Overview tickets";
            // 
            // BTNaddTicket
            // 
            this.BTNaddTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNaddTicket.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNaddTicket.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNaddTicket.Location = new System.Drawing.Point(1070, 164);
            this.BTNaddTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNaddTicket.Name = "BTNaddTicket";
            this.BTNaddTicket.Size = new System.Drawing.Size(150, 27);
            this.BTNaddTicket.TabIndex = 4;
            this.BTNaddTicket.Text = "Create Ticket";
            this.BTNaddTicket.UseVisualStyleBackColor = false;
            this.BTNaddTicket.Click += new System.EventHandler(this.BTNaddTicket_Click);
            // 
            // LVTickets
            // 
            this.LVTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Subject});
            this.LVTickets.HideSelection = false;
            this.LVTickets.Location = new System.Drawing.Point(41, 228);
            this.LVTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LVTickets.MultiSelect = false;
            this.LVTickets.Name = "LVTickets";
            this.LVTickets.Size = new System.Drawing.Size(817, 374);
            this.LVTickets.TabIndex = 5;
            this.LVTickets.UseCompatibleStateImageBehavior = false;
            this.LVTickets.SelectedIndexChanged += new System.EventHandler(this.LVTickets_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Width = 40;
            // 
            // DGV_Selected
            // 
            this.DGV_Selected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Selected.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Selected.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Selected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Selected.Location = new System.Drawing.Point(934, 228);
            this.DGV_Selected.Name = "DGV_Selected";
            this.DGV_Selected.ReadOnly = true;
            this.DGV_Selected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Selected.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Selected.RowHeadersVisible = false;
            this.DGV_Selected.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.DGV_Selected.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Selected.RowTemplate.Height = 25;
            this.DGV_Selected.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_Selected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Selected.ShowCellToolTips = false;
            this.DGV_Selected.Size = new System.Drawing.Size(286, 328);
            this.DGV_Selected.TabIndex = 6;
            // 
            // LBL_ticket
            // 
            this.LBL_ticket.AutoSize = true;
            this.LBL_ticket.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_ticket.Location = new System.Drawing.Point(934, 200);
            this.LBL_ticket.Name = "LBL_ticket";
            this.LBL_ticket.Size = new System.Drawing.Size(119, 25);
            this.LBL_ticket.TabIndex = 7;
            this.LBL_ticket.Text = "Ticket detail";
            // 
            // BTN_Update
            // 
            this.BTN_Update.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_Update.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Update.Location = new System.Drawing.Point(1070, 575);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(150, 27);
            this.BTN_Update.TabIndex = 8;
            this.BTN_Update.Text = "Update Ticket";
            this.BTN_Update.UseVisualStyleBackColor = false;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // BTN_TransferTicket
            // 
            this.BTN_TransferTicket.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_TransferTicket.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_TransferTicket.Location = new System.Drawing.Point(886, 575);
            this.BTN_TransferTicket.Name = "BTN_TransferTicket";
            this.BTN_TransferTicket.Size = new System.Drawing.Size(150, 27);
            this.BTN_TransferTicket.TabIndex = 9;
            this.BTN_TransferTicket.Text = "Transfer Ticket";
            this.BTN_TransferTicket.UseVisualStyleBackColor = false;
            this.BTN_TransferTicket.Click += new System.EventHandler(this.BTN_TransferTicket_Click);
            // 
            // BTN_RemoveTicket
            // 
            this.BTN_RemoveTicket.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_RemoveTicket.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_RemoveTicket.Location = new System.Drawing.Point(886, 164);
            this.BTN_RemoveTicket.Name = "BTN_RemoveTicket";
            this.BTN_RemoveTicket.Size = new System.Drawing.Size(150, 27);
            this.BTN_RemoveTicket.TabIndex = 10;
            this.BTN_RemoveTicket.Text = "Delete Ticket";
            this.BTN_RemoveTicket.UseVisualStyleBackColor = false;
            this.BTN_RemoveTicket.Click += new System.EventHandler(this.BTN_RemoveTicket_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(41, 631);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Show Status closed";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LBL_status
            // 
            this.LBL_status.AutoSize = true;
            this.LBL_status.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_status.Location = new System.Drawing.Point(41, 200);
            this.LBL_status.Name = "LBL_status";
            this.LBL_status.Size = new System.Drawing.Size(122, 25);
            this.LBL_status.TabIndex = 12;
            this.LBL_status.Text = "Open tickets";
            // 
            // BTNupdate
            // 
            this.BTNupdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNupdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNupdate.Location = new System.Drawing.Point(708, 628);
            this.BTNupdate.Name = "BTNupdate";
            this.BTNupdate.Size = new System.Drawing.Size(150, 27);
            this.BTNupdate.TabIndex = 13;
            this.BTNupdate.Text = "Update";
            this.BTNupdate.UseVisualStyleBackColor = false;
            this.BTNupdate.Click += new System.EventHandler(this.BTNupdate_Click);
            // 
            // Rbtn_LowToHigh
            // 
            this.Rbtn_LowToHigh.AutoSize = true;
            this.Rbtn_LowToHigh.Location = new System.Drawing.Point(767, 169);
            this.Rbtn_LowToHigh.Name = "Rbtn_LowToHigh";
            this.Rbtn_LowToHigh.Size = new System.Drawing.Size(91, 19);
            this.Rbtn_LowToHigh.TabIndex = 15;
            this.Rbtn_LowToHigh.TabStop = true;
            this.Rbtn_LowToHigh.Text = "Low To High";
            this.Rbtn_LowToHigh.UseVisualStyleBackColor = true;
            this.Rbtn_LowToHigh.CheckedChanged += new System.EventHandler(this.Rbtn_LowToHigh_CheckedChanged);
            // 
            // Rbtn_HightToLow
            // 
            this.Rbtn_HightToLow.AutoSize = true;
            this.Rbtn_HightToLow.Location = new System.Drawing.Point(670, 169);
            this.Rbtn_HightToLow.Name = "Rbtn_HightToLow";
            this.Rbtn_HightToLow.Size = new System.Drawing.Size(91, 19);
            this.Rbtn_HightToLow.TabIndex = 16;
            this.Rbtn_HightToLow.TabStop = true;
            this.Rbtn_HightToLow.Text = "High To Low";
            this.Rbtn_HightToLow.UseVisualStyleBackColor = true;
            this.Rbtn_HightToLow.CheckedChanged += new System.EventHandler(this.Rbtn_HightToLow_CheckedChanged);
            // 
            // Incident_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Rbtn_HightToLow);
            this.Controls.Add(this.Rbtn_LowToHigh);
            this.Controls.Add(this.BTNupdate);
            this.Controls.Add(this.LBL_status);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BTN_RemoveTicket);
            this.Controls.Add(this.BTN_TransferTicket);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.LBL_ticket);
            this.Controls.Add(this.DGV_Selected);
            this.Controls.Add(this.LVTickets);
            this.Controls.Add(this.BTNaddTicket);
            this.Controls.Add(this.LblTicket);
            this.Controls.Add(this.PNLmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Incident_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incident Management";
            this.Load += new System.EventHandler(this.Incident_Management_Load);
            this.PNLmain.ResumeLayout(false);
            this.PNLmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Selected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label LblTicket;
        private System.Windows.Forms.Button BTNaddTicket;
        private System.Windows.Forms.ListView LVTickets;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.DataGridView DGV_Selected;
        private System.Windows.Forms.Label LBL_ticket;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Button Btn_logOut;
        private System.Windows.Forms.Button BTN_TransferTicket;
        private System.Windows.Forms.Button BTN_RemoveTicket;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label LBL_status;
        private System.Windows.Forms.Button BTNupdate;
        private System.Windows.Forms.Button Btn_Sort;
        private System.Windows.Forms.RadioButton Rbtn_LowToHigh;
        private System.Windows.Forms.RadioButton Rbtn_HightToLow;
    }
}