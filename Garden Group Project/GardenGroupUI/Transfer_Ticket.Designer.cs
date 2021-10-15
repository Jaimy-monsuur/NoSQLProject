
namespace GardenGroupUI
{
    partial class Transfer_Ticket
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
            this.GB_AddTicket = new System.Windows.Forms.GroupBox();
            this.CB_TransferTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LV_SelectedTicket = new System.Windows.Forms.ListView();
            this.BTN_cancel = new System.Windows.Forms.Button();
            this.BTN_Transfer = new System.Windows.Forms.Button();
            this.LBL_Subject = new System.Windows.Forms.Label();
            this.LBL_SelectedTicket = new System.Windows.Forms.Label();
            this.LBL_Error = new System.Windows.Forms.Label();
            this.PNLmain = new System.Windows.Forms.Panel();
            this.Btn_logOut = new System.Windows.Forms.Button();
            this.LBLnodesk = new System.Windows.Forms.Label();
            this.LBLLicense = new System.Windows.Forms.Label();
            this.PBOX = new System.Windows.Forms.PictureBox();
            this.LBL_Selected = new System.Windows.Forms.Label();
            this.GB_AddTicket.SuspendLayout();
            this.PNLmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_AddTicket
            // 
            this.GB_AddTicket.AutoSize = true;
            this.GB_AddTicket.Controls.Add(this.LBL_Selected);
            this.GB_AddTicket.Controls.Add(this.CB_TransferTo);
            this.GB_AddTicket.Controls.Add(this.label1);
            this.GB_AddTicket.Controls.Add(this.LV_SelectedTicket);
            this.GB_AddTicket.Controls.Add(this.BTN_cancel);
            this.GB_AddTicket.Controls.Add(this.BTN_Transfer);
            this.GB_AddTicket.Controls.Add(this.LBL_Subject);
            this.GB_AddTicket.Controls.Add(this.LBL_SelectedTicket);
            this.GB_AddTicket.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GB_AddTicket.Location = new System.Drawing.Point(54, 128);
            this.GB_AddTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_AddTicket.Name = "GB_AddTicket";
            this.GB_AddTicket.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_AddTicket.Size = new System.Drawing.Size(780, 496);
            this.GB_AddTicket.TabIndex = 11;
            this.GB_AddTicket.TabStop = false;
            this.GB_AddTicket.Text = "Transfer Ticket";
            // 
            // CB_TransferTo
            // 
            this.CB_TransferTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TransferTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_TransferTo.FormattingEnabled = true;
            this.CB_TransferTo.Location = new System.Drawing.Point(372, 334);
            this.CB_TransferTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_TransferTo.Name = "CB_TransferTo";
            this.CB_TransferTo.Size = new System.Drawing.Size(219, 23);
            this.CB_TransferTo.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Transfer to: ";
            // 
            // LV_SelectedTicket
            // 
            this.LV_SelectedTicket.HideSelection = false;
            this.LV_SelectedTicket.Location = new System.Drawing.Point(217, 50);
            this.LV_SelectedTicket.Name = "LV_SelectedTicket";
            this.LV_SelectedTicket.Size = new System.Drawing.Size(557, 247);
            this.LV_SelectedTicket.TabIndex = 27;
            this.LV_SelectedTicket.UseCompatibleStateImageBehavior = false;
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.AutoSize = true;
            this.BTN_cancel.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_cancel.Location = new System.Drawing.Point(372, 442);
            this.BTN_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(122, 29);
            this.BTN_cancel.TabIndex = 26;
            this.BTN_cancel.Text = "Cancel";
            this.BTN_cancel.UseVisualStyleBackColor = false;
            this.BTN_cancel.Click += new System.EventHandler(this.BTN_cancel_Click);
            // 
            // BTN_Transfer
            // 
            this.BTN_Transfer.AutoSize = true;
            this.BTN_Transfer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_Transfer.Location = new System.Drawing.Point(610, 442);
            this.BTN_Transfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Transfer.Name = "BTN_Transfer";
            this.BTN_Transfer.Size = new System.Drawing.Size(122, 29);
            this.BTN_Transfer.TabIndex = 12;
            this.BTN_Transfer.Text = "Transfer";
            this.BTN_Transfer.UseVisualStyleBackColor = false;
            // 
            // LBL_Subject
            // 
            this.LBL_Subject.AutoSize = true;
            this.LBL_Subject.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Subject.Location = new System.Drawing.Point(32, 300);
            this.LBL_Subject.Name = "LBL_Subject";
            this.LBL_Subject.Size = new System.Drawing.Size(127, 15);
            this.LBL_Subject.TabIndex = 19;
            this.LBL_Subject.Text = "Person selected ticket: ";
            // 
            // LBL_SelectedTicket
            // 
            this.LBL_SelectedTicket.AutoSize = true;
            this.LBL_SelectedTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_SelectedTicket.Location = new System.Drawing.Point(32, 50);
            this.LBL_SelectedTicket.Name = "LBL_SelectedTicket";
            this.LBL_SelectedTicket.Size = new System.Drawing.Size(87, 15);
            this.LBL_SelectedTicket.TabIndex = 18;
            this.LBL_SelectedTicket.Text = "Selected ticket:";
            // 
            // LBL_Error
            // 
            this.LBL_Error.AutoSize = true;
            this.LBL_Error.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Error.ForeColor = System.Drawing.Color.Red;
            this.LBL_Error.Location = new System.Drawing.Point(54, 634);
            this.LBL_Error.Name = "LBL_Error";
            this.LBL_Error.Size = new System.Drawing.Size(0, 15);
            this.LBL_Error.TabIndex = 13;
            // 
            // PNLmain
            // 
            this.PNLmain.AutoSize = true;
            this.PNLmain.BackColor = System.Drawing.Color.DarkCyan;
            this.PNLmain.Controls.Add(this.Btn_logOut);
            this.PNLmain.Controls.Add(this.LBLnodesk);
            this.PNLmain.Controls.Add(this.LBLLicense);
            this.PNLmain.Controls.Add(this.PBOX);
            this.PNLmain.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNLmain.Location = new System.Drawing.Point(0, 0);
            this.PNLmain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PNLmain.Name = "PNLmain";
            this.PNLmain.Size = new System.Drawing.Size(894, 107);
            this.PNLmain.TabIndex = 14;
            // 
            // Btn_logOut
            // 
            this.Btn_logOut.AutoSize = true;
            this.Btn_logOut.BackColor = System.Drawing.Color.Teal;
            this.Btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_logOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_logOut.Location = new System.Drawing.Point(763, 64);
            this.Btn_logOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_logOut.Name = "Btn_logOut";
            this.Btn_logOut.Size = new System.Drawing.Size(122, 29);
            this.Btn_logOut.TabIndex = 27;
            this.Btn_logOut.Text = "Log Out";
            this.Btn_logOut.UseVisualStyleBackColor = false;
            this.Btn_logOut.Click += new System.EventHandler(this.Btn_logOut_Click);
            // 
            // LBLnodesk
            // 
            this.LBLnodesk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLnodesk.AutoSize = true;
            this.LBLnodesk.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLnodesk.Location = new System.Drawing.Point(763, 0);
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
            this.LBLLicense.Location = new System.Drawing.Point(649, 36);
            this.LBLLicense.Name = "LBLLicense";
            this.LBLLicense.Size = new System.Drawing.Size(242, 21);
            this.LBLLicense.TabIndex = 2;
            this.LBLLicense.Text = "Licensed to: The Garden Group";
            // 
            // PBOX
            // 
            this.PBOX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PBOX.InitialImage = null;
            this.PBOX.Location = new System.Drawing.Point(10, 11);
            this.PBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBOX.Name = "PBOX";
            this.PBOX.Size = new System.Drawing.Size(200, 79);
            this.PBOX.TabIndex = 0;
            this.PBOX.TabStop = false;
            // 
            // LBL_Selected
            // 
            this.LBL_Selected.AutoSize = true;
            this.LBL_Selected.Location = new System.Drawing.Point(372, 300);
            this.LBL_Selected.Name = "LBL_Selected";
            this.LBL_Selected.Size = new System.Drawing.Size(21, 19);
            this.LBL_Selected.TabIndex = 30;
            this.LBL_Selected.Text = "...";
            // 
            // Transfer_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(894, 681);
            this.Controls.Add(this.PNLmain);
            this.Controls.Add(this.LBL_Error);
            this.Controls.Add(this.GB_AddTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Transfer_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer_Ticket";
            this.Load += new System.EventHandler(this.Create_Ticket_Load);
            this.GB_AddTicket.ResumeLayout(false);
            this.GB_AddTicket.PerformLayout();
            this.PNLmain.ResumeLayout(false);
            this.PNLmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GB_AddTicket;
        private System.Windows.Forms.Label LBL_Subject;
        private System.Windows.Forms.Label LBL_SelectedTicket;
        private System.Windows.Forms.Button BTN_Transfer;
        private System.Windows.Forms.Label LBL_Error;
        private System.Windows.Forms.Panel PNLmain;
        private System.Windows.Forms.Label LBLnodesk;
        private System.Windows.Forms.Label LBLLicense;
        private System.Windows.Forms.PictureBox PBOX;
        private System.Windows.Forms.Button BTN_cancel;
        private System.Windows.Forms.Button Btn_logOut;
        private System.Windows.Forms.ListView LV_SelectedTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_TransferTo;
        private System.Windows.Forms.Label LBL_Selected;
    }
}