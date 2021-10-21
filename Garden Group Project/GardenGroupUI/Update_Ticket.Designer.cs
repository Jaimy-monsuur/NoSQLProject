
namespace GardenGroupUI
{
    partial class Update_Ticket
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GB_UpdateTicket = new System.Windows.Forms.GroupBox();
            this.LBL_Type = new System.Windows.Forms.Label();
            this.LBL_Subject = new System.Windows.Forms.Label();
            this.TXB_Subject = new System.Windows.Forms.MaskedTextBox();
            this.CB_incidentType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.LBL_description = new System.Windows.Forms.Label();
            this.DGV_Selected = new System.Windows.Forms.DataGridView();
            this.BTN_cancel = new System.Windows.Forms.Button();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.LBL_SelectedTicket = new System.Windows.Forms.Label();
            this.LBL_Error = new System.Windows.Forms.Label();
            this.PNLmain = new System.Windows.Forms.Panel();
            this.Btn_logOut = new System.Windows.Forms.Button();
            this.LBLnodesk = new System.Windows.Forms.Label();
            this.LBLLicense = new System.Windows.Forms.Label();
            this.GB_Close = new System.Windows.Forms.GroupBox();
            this.LB_close = new System.Windows.Forms.Label();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.GB_Escalate = new System.Windows.Forms.GroupBox();
            this.LBL_priority = new System.Windows.Forms.Label();
            this.CB_Priority = new System.Windows.Forms.ComboBox();
            this.BTN_Escalate = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PBOX = new System.Windows.Forms.PictureBox();
            this.GB_UpdateTicket.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Selected)).BeginInit();
            this.PNLmain.SuspendLayout();
            this.GB_Close.SuspendLayout();
            this.GB_Escalate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_UpdateTicket
            // 
            this.GB_UpdateTicket.AutoSize = true;
            this.GB_UpdateTicket.CausesValidation = false;
            this.GB_UpdateTicket.Controls.Add(this.LBL_Type);
            this.GB_UpdateTicket.Controls.Add(this.LBL_Subject);
            this.GB_UpdateTicket.Controls.Add(this.TXB_Subject);
            this.GB_UpdateTicket.Controls.Add(this.CB_incidentType);
            this.GB_UpdateTicket.Controls.Add(this.panel1);
            this.GB_UpdateTicket.Controls.Add(this.LBL_description);
            this.GB_UpdateTicket.Controls.Add(this.DGV_Selected);
            this.GB_UpdateTicket.Controls.Add(this.BTN_cancel);
            this.GB_UpdateTicket.Controls.Add(this.BTN_Update);
            this.GB_UpdateTicket.Controls.Add(this.LBL_SelectedTicket);
            this.GB_UpdateTicket.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GB_UpdateTicket.Location = new System.Drawing.Point(54, 120);
            this.GB_UpdateTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_UpdateTicket.Name = "GB_UpdateTicket";
            this.GB_UpdateTicket.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_UpdateTicket.Size = new System.Drawing.Size(780, 419);
            this.GB_UpdateTicket.TabIndex = 11;
            this.GB_UpdateTicket.TabStop = false;
            this.GB_UpdateTicket.Text = "Update Ticket";
            // 
            // LBL_Type
            // 
            this.LBL_Type.AutoSize = true;
            this.LBL_Type.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Type.Location = new System.Drawing.Point(21, 106);
            this.LBL_Type.Name = "LBL_Type";
            this.LBL_Type.Size = new System.Drawing.Size(80, 15);
            this.LBL_Type.TabIndex = 33;
            this.LBL_Type.Text = "Incident type:";
            // 
            // LBL_Subject
            // 
            this.LBL_Subject.AutoSize = true;
            this.LBL_Subject.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Subject.Location = new System.Drawing.Point(21, 65);
            this.LBL_Subject.Name = "LBL_Subject";
            this.LBL_Subject.Size = new System.Drawing.Size(53, 15);
            this.LBL_Subject.TabIndex = 32;
            this.LBL_Subject.Text = "Subject: ";
            // 
            // TXB_Subject
            // 
            this.TXB_Subject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXB_Subject.Location = new System.Drawing.Point(247, 65);
            this.TXB_Subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXB_Subject.Name = "TXB_Subject";
            this.TXB_Subject.Size = new System.Drawing.Size(219, 23);
            this.TXB_Subject.TabIndex = 31;
            // 
            // CB_incidentType
            // 
            this.CB_incidentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_incidentType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_incidentType.FormattingEnabled = true;
            this.CB_incidentType.Location = new System.Drawing.Point(247, 106);
            this.CB_incidentType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_incidentType.Name = "CB_incidentType";
            this.CB_incidentType.Size = new System.Drawing.Size(219, 23);
            this.CB_incidentType.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RTB_Description);
            this.panel1.Location = new System.Drawing.Point(106, 159);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Size = new System.Drawing.Size(360, 190);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RTB_Description
            // 
            this.RTB_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Description.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB_Description.Location = new System.Drawing.Point(3, 2);
            this.RTB_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(354, 186);
            this.RTB_Description.TabIndex = 16;
            this.RTB_Description.Text = "";
            // 
            // LBL_description
            // 
            this.LBL_description.AutoSize = true;
            this.LBL_description.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_description.Location = new System.Drawing.Point(18, 159);
            this.LBL_description.Name = "LBL_description";
            this.LBL_description.Size = new System.Drawing.Size(71, 15);
            this.LBL_description.TabIndex = 28;
            this.LBL_description.Text = "Desctiption:";
            // 
            // DGV_Selected
            // 
            this.DGV_Selected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Selected.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Selected.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Selected.Location = new System.Drawing.Point(488, 39);
            this.DGV_Selected.Name = "DGV_Selected";
            this.DGV_Selected.ReadOnly = true;
            this.DGV_Selected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Selected.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Selected.RowHeadersVisible = false;
            this.DGV_Selected.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.DGV_Selected.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Selected.RowTemplate.Height = 25;
            this.DGV_Selected.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_Selected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Selected.ShowCellToolTips = false;
            this.DGV_Selected.Size = new System.Drawing.Size(286, 310);
            this.DGV_Selected.TabIndex = 27;
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.AutoSize = true;
            this.BTN_cancel.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_cancel.Location = new System.Drawing.Point(414, 367);
            this.BTN_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(122, 29);
            this.BTN_cancel.TabIndex = 26;
            this.BTN_cancel.Text = "Cancel";
            this.BTN_cancel.UseVisualStyleBackColor = false;
            this.BTN_cancel.Click += new System.EventHandler(this.BTN_cancel_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.AutoSize = true;
            this.BTN_Update.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_Update.Location = new System.Drawing.Point(652, 367);
            this.BTN_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(122, 29);
            this.BTN_Update.TabIndex = 12;
            this.BTN_Update.Text = "Update";
            this.BTN_Update.UseVisualStyleBackColor = false;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // LBL_SelectedTicket
            // 
            this.LBL_SelectedTicket.AutoSize = true;
            this.LBL_SelectedTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_SelectedTicket.Location = new System.Drawing.Point(488, 21);
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
            this.LBL_Error.Location = new System.Drawing.Point(54, 658);
            this.LBL_Error.Name = "LBL_Error";
            this.LBL_Error.Size = new System.Drawing.Size(0, 15);
            this.LBL_Error.TabIndex = 13;
            // 
            // PNLmain
            // 
            this.PNLmain.AutoSize = true;
            this.PNLmain.BackColor = System.Drawing.Color.DarkCyan;
            this.PNLmain.Controls.Add(this.PBOX);
            this.PNLmain.Controls.Add(this.Btn_logOut);
            this.PNLmain.Controls.Add(this.LBLnodesk);
            this.PNLmain.Controls.Add(this.LBLLicense);
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
            // GB_Close
            // 
            this.GB_Close.Controls.Add(this.LB_close);
            this.GB_Close.Controls.Add(this.BTN_Close);
            this.GB_Close.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GB_Close.Location = new System.Drawing.Point(459, 545);
            this.GB_Close.Name = "GB_Close";
            this.GB_Close.Size = new System.Drawing.Size(375, 115);
            this.GB_Close.TabIndex = 15;
            this.GB_Close.TabStop = false;
            this.GB_Close.Text = "Close Ticket";
            // 
            // LB_close
            // 
            this.LB_close.AutoSize = true;
            this.LB_close.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB_close.Location = new System.Drawing.Point(18, 41);
            this.LB_close.Name = "LB_close";
            this.LB_close.Size = new System.Drawing.Size(214, 15);
            this.LB_close.TabIndex = 24;
            this.LB_close.Text = "Ticket status will be changed to: Closed";
            // 
            // BTN_Close
            // 
            this.BTN_Close.AutoSize = true;
            this.BTN_Close.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_Close.Location = new System.Drawing.Point(247, 81);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(122, 29);
            this.BTN_Close.TabIndex = 13;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // GB_Escalate
            // 
            this.GB_Escalate.Controls.Add(this.LBL_priority);
            this.GB_Escalate.Controls.Add(this.CB_Priority);
            this.GB_Escalate.Controls.Add(this.BTN_Escalate);
            this.GB_Escalate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GB_Escalate.Location = new System.Drawing.Point(54, 545);
            this.GB_Escalate.Name = "GB_Escalate";
            this.GB_Escalate.Size = new System.Drawing.Size(378, 115);
            this.GB_Escalate.TabIndex = 16;
            this.GB_Escalate.TabStop = false;
            this.GB_Escalate.Text = "Escalate Priority";
            // 
            // LBL_priority
            // 
            this.LBL_priority.AutoSize = true;
            this.LBL_priority.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_priority.Location = new System.Drawing.Point(21, 41);
            this.LBL_priority.Name = "LBL_priority";
            this.LBL_priority.Size = new System.Drawing.Size(48, 15);
            this.LBL_priority.TabIndex = 23;
            this.LBL_priority.Text = "Priority:";
            // 
            // CB_Priority
            // 
            this.CB_Priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Priority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_Priority.FormattingEnabled = true;
            this.CB_Priority.Location = new System.Drawing.Point(131, 41);
            this.CB_Priority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_Priority.Name = "CB_Priority";
            this.CB_Priority.Size = new System.Drawing.Size(219, 23);
            this.CB_Priority.TabIndex = 14;
            // 
            // BTN_Escalate
            // 
            this.BTN_Escalate.AutoSize = true;
            this.BTN_Escalate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_Escalate.Location = new System.Drawing.Point(250, 81);
            this.BTN_Escalate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Escalate.Name = "BTN_Escalate";
            this.BTN_Escalate.Size = new System.Drawing.Size(122, 29);
            this.BTN_Escalate.TabIndex = 13;
            this.BTN_Escalate.Text = "Escalate";
            this.BTN_Escalate.UseVisualStyleBackColor = false;
            this.BTN_Escalate.Click += new System.EventHandler(this.BTN_Escalate_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PBOX
            // 
            this.PBOX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PBOX.Image = global::GardenGroupUI.Properties.Resources.GardenGourp;
            this.PBOX.InitialImage = null;
            this.PBOX.Location = new System.Drawing.Point(12, 11);
            this.PBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBOX.Name = "PBOX";
            this.PBOX.Size = new System.Drawing.Size(168, 82);
            this.PBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBOX.TabIndex = 28;
            this.PBOX.TabStop = false;
            // 
            // Update_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(894, 681);
            this.Controls.Add(this.GB_Escalate);
            this.Controls.Add(this.GB_Close);
            this.Controls.Add(this.PNLmain);
            this.Controls.Add(this.LBL_Error);
            this.Controls.Add(this.GB_UpdateTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Update_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Ticket";
            this.Load += new System.EventHandler(this.Create_Ticket_Load);
            this.GB_UpdateTicket.ResumeLayout(false);
            this.GB_UpdateTicket.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Selected)).EndInit();
            this.PNLmain.ResumeLayout(false);
            this.PNLmain.PerformLayout();
            this.GB_Close.ResumeLayout(false);
            this.GB_Close.PerformLayout();
            this.GB_Escalate.ResumeLayout(false);
            this.GB_Escalate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GB_UpdateTicket;
        private System.Windows.Forms.Label LBL_SelectedTicket;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Label LBL_Error;
        private System.Windows.Forms.Panel PNLmain;
        private System.Windows.Forms.Label LBLnodesk;
        private System.Windows.Forms.Label LBLLicense;
        private System.Windows.Forms.Button BTN_cancel;
        private System.Windows.Forms.Button Btn_logOut;
        private System.Windows.Forms.DataGridView DGV_Selected;
        private System.Windows.Forms.GroupBox GB_Close;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.GroupBox GB_Escalate;
        private System.Windows.Forms.Button BTN_Escalate;
        private System.Windows.Forms.ComboBox CB_Priority;
        private System.Windows.Forms.Label LBL_priority;
        private System.Windows.Forms.Label LB_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_description;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LBL_Type;
        private System.Windows.Forms.Label LBL_Subject;
        private System.Windows.Forms.MaskedTextBox TXB_Subject;
        private System.Windows.Forms.ComboBox CB_incidentType;
        private System.Windows.Forms.PictureBox PBOX;
    }
}