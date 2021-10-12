
namespace GardenGroupUI
{
    partial class Create_Ticket
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
            this.LBLLicense = new System.Windows.Forms.Label();
            this.LBLnodesk = new System.Windows.Forms.Label();
            this.PBOX = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_AddTicket = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.LBL_description = new System.Windows.Forms.Label();
            this.LBL_deadline = new System.Windows.Forms.Label();
            this.LBL_priority = new System.Windows.Forms.Label();
            this.LBL_user = new System.Windows.Forms.Label();
            this.LBL_Type = new System.Windows.Forms.Label();
            this.LBL_Subject = new System.Windows.Forms.Label();
            this.LBL_reportdate = new System.Windows.Forms.Label();
            this.DTP_ReportDate = new System.Windows.Forms.DateTimePicker();
            this.DTP_Deadline = new System.Windows.Forms.DateTimePicker();
            this.TXB_Subject = new System.Windows.Forms.MaskedTextBox();
            this.CB_Priority = new System.Windows.Forms.ComboBox();
            this.CB_ReportedBy = new System.Windows.Forms.ComboBox();
            this.CB_incidentType = new System.Windows.Forms.ComboBox();
            this.BTN_add = new System.Windows.Forms.Button();
            this.PNLmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).BeginInit();
            this.Menu.SuspendLayout();
            this.GB_AddTicket.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.PNLmain.TabIndex = 1;
            this.PNLmain.Paint += new System.Windows.Forms.PaintEventHandler(this.PNLmain_Paint);
            // 
            // LBLLicense
            // 
            this.LBLLicense.AutoSize = true;
            this.LBLLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLLicense.Location = new System.Drawing.Point(947, 59);
            this.LBLLicense.Name = "LBLLicense";
            this.LBLLicense.Size = new System.Drawing.Size(303, 28);
            this.LBLLicense.TabIndex = 2;
            this.LBLLicense.Text = "Licensed to: The Garden Group";
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
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
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
            // GB_AddTicket
            // 
            this.GB_AddTicket.Controls.Add(this.panel1);
            this.GB_AddTicket.Controls.Add(this.LBL_description);
            this.GB_AddTicket.Controls.Add(this.LBL_deadline);
            this.GB_AddTicket.Controls.Add(this.LBL_priority);
            this.GB_AddTicket.Controls.Add(this.LBL_user);
            this.GB_AddTicket.Controls.Add(this.LBL_Type);
            this.GB_AddTicket.Controls.Add(this.LBL_Subject);
            this.GB_AddTicket.Controls.Add(this.LBL_reportdate);
            this.GB_AddTicket.Controls.Add(this.DTP_ReportDate);
            this.GB_AddTicket.Controls.Add(this.DTP_Deadline);
            this.GB_AddTicket.Controls.Add(this.TXB_Subject);
            this.GB_AddTicket.Controls.Add(this.CB_Priority);
            this.GB_AddTicket.Controls.Add(this.CB_ReportedBy);
            this.GB_AddTicket.Controls.Add(this.CB_incidentType);
            this.GB_AddTicket.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GB_AddTicket.Location = new System.Drawing.Point(130, 157);
            this.GB_AddTicket.Name = "GB_AddTicket";
            this.GB_AddTicket.Size = new System.Drawing.Size(1000, 440);
            this.GB_AddTicket.TabIndex = 11;
            this.GB_AddTicket.TabStop = false;
            this.GB_AddTicket.Text = "Create Ticket";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RTB_Description);
            this.panel1.Location = new System.Drawing.Point(512, 292);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(411, 125);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RTB_Description
            // 
            this.RTB_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Description.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB_Description.Location = new System.Drawing.Point(3, 3);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(405, 119);
            this.RTB_Description.TabIndex = 15;
            this.RTB_Description.Text = "";
            // 
            // LBL_description
            // 
            this.LBL_description.AutoSize = true;
            this.LBL_description.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_description.Location = new System.Drawing.Point(123, 292);
            this.LBL_description.Name = "LBL_description";
            this.LBL_description.Size = new System.Drawing.Size(90, 20);
            this.LBL_description.TabIndex = 24;
            this.LBL_description.Text = "Desctiption:";
            // 
            // LBL_deadline
            // 
            this.LBL_deadline.AutoSize = true;
            this.LBL_deadline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_deadline.Location = new System.Drawing.Point(123, 262);
            this.LBL_deadline.Name = "LBL_deadline";
            this.LBL_deadline.Size = new System.Drawing.Size(74, 20);
            this.LBL_deadline.TabIndex = 23;
            this.LBL_deadline.Text = "Deadline:";
            // 
            // LBL_priority
            // 
            this.LBL_priority.AutoSize = true;
            this.LBL_priority.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_priority.Location = new System.Drawing.Point(123, 214);
            this.LBL_priority.Name = "LBL_priority";
            this.LBL_priority.Size = new System.Drawing.Size(64, 20);
            this.LBL_priority.TabIndex = 22;
            this.LBL_priority.Text = "Priority:";
            // 
            // LBL_user
            // 
            this.LBL_user.AutoSize = true;
            this.LBL_user.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_user.Location = new System.Drawing.Point(123, 170);
            this.LBL_user.Name = "LBL_user";
            this.LBL_user.Size = new System.Drawing.Size(97, 20);
            this.LBL_user.TabIndex = 21;
            this.LBL_user.Text = "Reported by:";
            // 
            // LBL_Type
            // 
            this.LBL_Type.AutoSize = true;
            this.LBL_Type.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Type.Location = new System.Drawing.Point(123, 120);
            this.LBL_Type.Name = "LBL_Type";
            this.LBL_Type.Size = new System.Drawing.Size(102, 20);
            this.LBL_Type.TabIndex = 20;
            this.LBL_Type.Text = "Incident type:";
            // 
            // LBL_Subject
            // 
            this.LBL_Subject.AutoSize = true;
            this.LBL_Subject.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Subject.Location = new System.Drawing.Point(123, 77);
            this.LBL_Subject.Name = "LBL_Subject";
            this.LBL_Subject.Size = new System.Drawing.Size(67, 20);
            this.LBL_Subject.TabIndex = 19;
            this.LBL_Subject.Text = "Subject: ";
            // 
            // LBL_reportdate
            // 
            this.LBL_reportdate.AutoSize = true;
            this.LBL_reportdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_reportdate.Location = new System.Drawing.Point(123, 38);
            this.LBL_reportdate.Name = "LBL_reportdate";
            this.LBL_reportdate.Size = new System.Drawing.Size(95, 20);
            this.LBL_reportdate.TabIndex = 18;
            this.LBL_reportdate.Text = "Report Date:";
            // 
            // DTP_ReportDate
            // 
            this.DTP_ReportDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTP_ReportDate.Location = new System.Drawing.Point(512, 31);
            this.DTP_ReportDate.Name = "DTP_ReportDate";
            this.DTP_ReportDate.Size = new System.Drawing.Size(250, 27);
            this.DTP_ReportDate.TabIndex = 17;
            // 
            // DTP_Deadline
            // 
            this.DTP_Deadline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTP_Deadline.Location = new System.Drawing.Point(512, 257);
            this.DTP_Deadline.Name = "DTP_Deadline";
            this.DTP_Deadline.Size = new System.Drawing.Size(250, 27);
            this.DTP_Deadline.TabIndex = 16;
            // 
            // TXB_Subject
            // 
            this.TXB_Subject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXB_Subject.Location = new System.Drawing.Point(512, 74);
            this.TXB_Subject.Name = "TXB_Subject";
            this.TXB_Subject.Size = new System.Drawing.Size(250, 27);
            this.TXB_Subject.TabIndex = 14;
            // 
            // CB_Priority
            // 
            this.CB_Priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Priority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_Priority.FormattingEnabled = true;
            this.CB_Priority.Location = new System.Drawing.Point(512, 211);
            this.CB_Priority.Name = "CB_Priority";
            this.CB_Priority.Size = new System.Drawing.Size(250, 28);
            this.CB_Priority.TabIndex = 13;
            // 
            // CB_ReportedBy
            // 
            this.CB_ReportedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ReportedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_ReportedBy.FormattingEnabled = true;
            this.CB_ReportedBy.Location = new System.Drawing.Point(512, 167);
            this.CB_ReportedBy.Name = "CB_ReportedBy";
            this.CB_ReportedBy.Size = new System.Drawing.Size(250, 28);
            this.CB_ReportedBy.TabIndex = 12;
            // 
            // CB_incidentType
            // 
            this.CB_incidentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_incidentType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_incidentType.FormattingEnabled = true;
            this.CB_incidentType.Location = new System.Drawing.Point(512, 117);
            this.CB_incidentType.Name = "CB_incidentType";
            this.CB_incidentType.Size = new System.Drawing.Size(250, 28);
            this.CB_incidentType.TabIndex = 11;
            // 
            // BTN_add
            // 
            this.BTN_add.Location = new System.Drawing.Point(990, 621);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(140, 29);
            this.BTN_add.TabIndex = 12;
            this.BTN_add.Text = "Add";
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // Create_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.GB_AddTicket);
            this.Controls.Add(this.PNLmain);
            this.Name = "Create_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_Ticket";
            this.Load += new System.EventHandler(this.Create_Ticket_Load);
            this.PNLmain.ResumeLayout(false);
            this.PNLmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.GB_AddTicket.ResumeLayout(false);
            this.GB_AddTicket.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNLmain;
        private System.Windows.Forms.Label LBLLicense;
        private System.Windows.Forms.Label LBLnodesk;
        private System.Windows.Forms.PictureBox PBOX;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.GroupBox GB_AddTicket;
        private System.Windows.Forms.Label LBL_Type;
        private System.Windows.Forms.Label LBL_Subject;
        private System.Windows.Forms.Label LBL_reportdate;
        private System.Windows.Forms.DateTimePicker DTP_ReportDate;
        private System.Windows.Forms.DateTimePicker DTP_Deadline;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.MaskedTextBox TXB_Subject;
        private System.Windows.Forms.ComboBox CB_Priority;
        private System.Windows.Forms.ComboBox CB_ReportedBy;
        private System.Windows.Forms.ComboBox CB_incidentType;
        private System.Windows.Forms.Label LBL_description;
        private System.Windows.Forms.Label LBL_deadline;
        private System.Windows.Forms.Label LBL_priority;
        private System.Windows.Forms.Label LBL_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_add;
    }
}