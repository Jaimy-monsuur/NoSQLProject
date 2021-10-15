
namespace GardenGroupUI
{
    partial class Create_User
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
            this.GB_AddUser = new System.Windows.Forms.GroupBox();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.LBL_Location = new System.Windows.Forms.Label();
            this.LBL_PhoneNumber = new System.Windows.Forms.Label();
            this.LBL_EmailAddress = new System.Windows.Forms.Label();
            this.LBL_Type = new System.Windows.Forms.Label();
            this.LBL_LastName = new System.Windows.Forms.Label();
            this.LBL_FirstName = new System.Windows.Forms.Label();
            this.CB_UserType = new System.Windows.Forms.ComboBox();
            this.LBL_Error = new System.Windows.Forms.Label();
            this.PNLmain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLLicense = new System.Windows.Forms.Label();
            this.LBLnodesk = new System.Windows.Forms.Label();
            this.PBOX = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TXB_FirstName = new System.Windows.Forms.MaskedTextBox();
            this.TXB_EmailAdress = new System.Windows.Forms.MaskedTextBox();
            this.TXB_PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.TXB_Location = new System.Windows.Forms.MaskedTextBox();
            this.TXB_Password = new System.Windows.Forms.MaskedTextBox();
            this.TXB_LastName = new System.Windows.Forms.MaskedTextBox();
            this.GB_AddUser.SuspendLayout();
            this.PNLmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_AddUser
            // 
            this.GB_AddUser.AutoSize = true;
            this.GB_AddUser.Controls.Add(this.TXB_LastName);
            this.GB_AddUser.Controls.Add(this.TXB_Password);
            this.GB_AddUser.Controls.Add(this.TXB_Location);
            this.GB_AddUser.Controls.Add(this.TXB_PhoneNumber);
            this.GB_AddUser.Controls.Add(this.TXB_EmailAdress);
            this.GB_AddUser.Controls.Add(this.TXB_FirstName);
            this.GB_AddUser.Controls.Add(this.LBL_Password);
            this.GB_AddUser.Controls.Add(this.BTN_Add);
            this.GB_AddUser.Controls.Add(this.LBL_Location);
            this.GB_AddUser.Controls.Add(this.LBL_PhoneNumber);
            this.GB_AddUser.Controls.Add(this.LBL_EmailAddress);
            this.GB_AddUser.Controls.Add(this.LBL_Type);
            this.GB_AddUser.Controls.Add(this.LBL_LastName);
            this.GB_AddUser.Controls.Add(this.LBL_FirstName);
            this.GB_AddUser.Controls.Add(this.CB_UserType);
            this.GB_AddUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GB_AddUser.Location = new System.Drawing.Point(130, 130);
            this.GB_AddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_AddUser.Name = "GB_AddUser";
            this.GB_AddUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_AddUser.Size = new System.Drawing.Size(1000, 500);
            this.GB_AddUser.TabIndex = 11;
            this.GB_AddUser.TabStop = false;
            this.GB_AddUser.Text = "Create User";
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Password.Location = new System.Drawing.Point(138, 318);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(60, 15);
            this.LBL_Password.TabIndex = 24;
            this.LBL_Password.Text = "Password:";
            // 
            // BTN_Add
            // 
            this.BTN_Add.AutoSize = true;
            this.BTN_Add.Location = new System.Drawing.Point(716, 443);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(122, 29);
            this.BTN_Add.TabIndex = 12;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // LBL_Location
            // 
            this.LBL_Location.AutoSize = true;
            this.LBL_Location.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Location.Location = new System.Drawing.Point(138, 267);
            this.LBL_Location.Name = "LBL_Location";
            this.LBL_Location.Size = new System.Drawing.Size(56, 15);
            this.LBL_Location.TabIndex = 23;
            this.LBL_Location.Text = "Location:";
            // 
            // LBL_PhoneNumber
            // 
            this.LBL_PhoneNumber.AutoSize = true;
            this.LBL_PhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_PhoneNumber.Location = new System.Drawing.Point(138, 220);
            this.LBL_PhoneNumber.Name = "LBL_PhoneNumber";
            this.LBL_PhoneNumber.Size = new System.Drawing.Size(89, 15);
            this.LBL_PhoneNumber.TabIndex = 22;
            this.LBL_PhoneNumber.Text = "Phone number:";
            // 
            // LBL_EmailAddress
            // 
            this.LBL_EmailAddress.AutoSize = true;
            this.LBL_EmailAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_EmailAddress.Location = new System.Drawing.Point(138, 174);
            this.LBL_EmailAddress.Name = "LBL_EmailAddress";
            this.LBL_EmailAddress.Size = new System.Drawing.Size(82, 15);
            this.LBL_EmailAddress.TabIndex = 21;
            this.LBL_EmailAddress.Text = "Email address:";
            // 
            // LBL_Type
            // 
            this.LBL_Type.AutoSize = true;
            this.LBL_Type.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Type.Location = new System.Drawing.Point(138, 132);
            this.LBL_Type.Name = "LBL_Type";
            this.LBL_Type.Size = new System.Drawing.Size(59, 15);
            this.LBL_Type.TabIndex = 20;
            this.LBL_Type.Text = "User type:";
            // 
            // LBL_LastName
            // 
            this.LBL_LastName.AutoSize = true;
            this.LBL_LastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_LastName.Location = new System.Drawing.Point(138, 91);
            this.LBL_LastName.Name = "LBL_LastName";
            this.LBL_LastName.Size = new System.Drawing.Size(67, 15);
            this.LBL_LastName.TabIndex = 19;
            this.LBL_LastName.Text = "Last name: ";
            // 
            // LBL_FirstName
            // 
            this.LBL_FirstName.AutoSize = true;
            this.LBL_FirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_FirstName.Location = new System.Drawing.Point(138, 51);
            this.LBL_FirstName.Name = "LBL_FirstName";
            this.LBL_FirstName.Size = new System.Drawing.Size(65, 15);
            this.LBL_FirstName.TabIndex = 18;
            this.LBL_FirstName.Text = "First name:";
            // 
            // CB_UserType
            // 
            this.CB_UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_UserType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_UserType.FormattingEnabled = true;
            this.CB_UserType.Location = new System.Drawing.Point(478, 129);
            this.CB_UserType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_UserType.Name = "CB_UserType";
            this.CB_UserType.Size = new System.Drawing.Size(219, 23);
            this.CB_UserType.TabIndex = 11;
            // 
            // LBL_Error
            // 
            this.LBL_Error.AutoSize = true;
            this.LBL_Error.ForeColor = System.Drawing.Color.Red;
            this.LBL_Error.Location = new System.Drawing.Point(114, 466);
            this.LBL_Error.Name = "LBL_Error";
            this.LBL_Error.Size = new System.Drawing.Size(0, 15);
            this.LBL_Error.TabIndex = 13;
            // 
            // PNLmain
            // 
            this.PNLmain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLmain.AutoSize = true;
            this.PNLmain.BackColor = System.Drawing.Color.DarkCyan;
            this.PNLmain.Controls.Add(this.label1);
            this.PNLmain.Controls.Add(this.label2);
            this.PNLmain.Controls.Add(this.LBLLicense);
            this.PNLmain.Controls.Add(this.LBLnodesk);
            this.PNLmain.Controls.Add(this.PBOX);
            this.PNLmain.Controls.Add(this.Menu);
            this.PNLmain.Location = new System.Drawing.Point(0, 0);
            this.PNLmain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PNLmain.Name = "PNLmain";
            this.PNLmain.Size = new System.Drawing.Size(1266, 93);
            this.PNLmain.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(989, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Licensed to: The Garden Group";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1116, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "NoDesk";
            // 
            // LBLLicense
            // 
            this.LBLLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLLicense.AutoSize = true;
            this.LBLLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLLicense.Location = new System.Drawing.Point(1920, 62);
            this.LBLLicense.Name = "LBLLicense";
            this.LBLLicense.Size = new System.Drawing.Size(242, 21);
            this.LBLLicense.TabIndex = 2;
            this.LBLLicense.Text = "Licensed to: The Garden Group";
            // 
            // LBLnodesk
            // 
            this.LBLnodesk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLnodesk.AutoSize = true;
            this.LBLnodesk.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLnodesk.Location = new System.Drawing.Point(2046, 7);
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
            this.Menu.BackColor = System.Drawing.Color.DarkCyan;
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
            // TXB_FirstName
            // 
            this.TXB_FirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXB_FirstName.Location = new System.Drawing.Point(478, 48);
            this.TXB_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXB_FirstName.Name = "TXB_FirstName";
            this.TXB_FirstName.Size = new System.Drawing.Size(219, 23);
            this.TXB_FirstName.TabIndex = 25;
            // 
            // TXB_EmailAdress
            // 
            this.TXB_EmailAdress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXB_EmailAdress.Location = new System.Drawing.Point(478, 171);
            this.TXB_EmailAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXB_EmailAdress.Name = "TXB_EmailAdress";
            this.TXB_EmailAdress.Size = new System.Drawing.Size(219, 23);
            this.TXB_EmailAdress.TabIndex = 26;
            // 
            // TXB_PhoneNumber
            // 
            this.TXB_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXB_PhoneNumber.Location = new System.Drawing.Point(478, 217);
            this.TXB_PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXB_PhoneNumber.Name = "TXB_PhoneNumber";
            this.TXB_PhoneNumber.Size = new System.Drawing.Size(219, 23);
            this.TXB_PhoneNumber.TabIndex = 27;
            // 
            // TXB_Location
            // 
            this.TXB_Location.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXB_Location.Location = new System.Drawing.Point(478, 264);
            this.TXB_Location.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXB_Location.Name = "TXB_Location";
            this.TXB_Location.Size = new System.Drawing.Size(219, 23);
            this.TXB_Location.TabIndex = 28;
            // 
            // TXB_Password
            // 
            this.TXB_Password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXB_Password.Location = new System.Drawing.Point(478, 315);
            this.TXB_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXB_Password.Name = "TXB_Password";
            this.TXB_Password.Size = new System.Drawing.Size(219, 23);
            this.TXB_Password.TabIndex = 29;
            // 
            // TXB_LastName
            // 
            this.TXB_LastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXB_LastName.Location = new System.Drawing.Point(478, 88);
            this.TXB_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXB_LastName.Name = "TXB_LastName";
            this.TXB_LastName.Size = new System.Drawing.Size(219, 23);
            this.TXB_LastName.TabIndex = 30;
            // 
            // Create_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PNLmain);
            this.Controls.Add(this.LBL_Error);
            this.Controls.Add(this.GB_AddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Create_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_Ticket";
            this.Load += new System.EventHandler(this.Create_User_Load);
            this.GB_AddUser.ResumeLayout(false);
            this.GB_AddUser.PerformLayout();
            this.PNLmain.ResumeLayout(false);
            this.PNLmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GB_AddUser;
        private System.Windows.Forms.Label LBL_Type;
        private System.Windows.Forms.Label LBL_LastName;
        private System.Windows.Forms.Label LBL_FirstName;
        private System.Windows.Forms.ComboBox CB_UserType;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.Label LBL_Location;
        private System.Windows.Forms.Label LBL_PhoneNumber;
        private System.Windows.Forms.Label LBL_EmailAddress;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Label LBL_Error;
        private System.Windows.Forms.Panel PNLmain;
        private System.Windows.Forms.Label LBLLicense;
        private System.Windows.Forms.Label LBLnodesk;
        private System.Windows.Forms.PictureBox PBOX;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TXB_Password;
        private System.Windows.Forms.MaskedTextBox TXB_Location;
        private System.Windows.Forms.MaskedTextBox TXB_PhoneNumber;
        private System.Windows.Forms.MaskedTextBox TXB_EmailAdress;
        private System.Windows.Forms.MaskedTextBox TXB_FirstName;
        private System.Windows.Forms.MaskedTextBox TXB_LastName;
    }
}