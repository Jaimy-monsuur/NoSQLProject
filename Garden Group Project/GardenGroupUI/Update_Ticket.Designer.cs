
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GB_UpdateTicket = new System.Windows.Forms.GroupBox();
            this.DGV_Selected = new System.Windows.Forms.DataGridView();
            this.BTN_cancel = new System.Windows.Forms.Button();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.LBL_SelectedTicket = new System.Windows.Forms.Label();
            this.LBL_Error = new System.Windows.Forms.Label();
            this.PNLmain = new System.Windows.Forms.Panel();
            this.Btn_logOut = new System.Windows.Forms.Button();
            this.LBLnodesk = new System.Windows.Forms.Label();
            this.LBLLicense = new System.Windows.Forms.Label();
            this.PBOX = new System.Windows.Forms.PictureBox();
            this.GB_Close = new System.Windows.Forms.GroupBox();
            this.LB_close = new System.Windows.Forms.Label();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.GB_Escalate = new System.Windows.Forms.GroupBox();
            this.LBL_priority = new System.Windows.Forms.Label();
            this.CB_Priority = new System.Windows.Forms.ComboBox();
            this.BTN_Escalate = new System.Windows.Forms.Button();
            this.GB_UpdateTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Selected)).BeginInit();
            this.PNLmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).BeginInit();
            this.GB_Close.SuspendLayout();
            this.GB_Escalate.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_UpdateTicket
            // 
            this.GB_UpdateTicket.AutoSize = true;
            this.GB_UpdateTicket.CausesValidation = false;
            this.GB_UpdateTicket.Controls.Add(this.DGV_Selected);
            this.GB_UpdateTicket.Controls.Add(this.BTN_cancel);
            this.GB_UpdateTicket.Controls.Add(this.BTN_Update);
            this.GB_UpdateTicket.Controls.Add(this.LBL_SelectedTicket);
            this.GB_UpdateTicket.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GB_UpdateTicket.Location = new System.Drawing.Point(54, 120);
            this.GB_UpdateTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_UpdateTicket.Name = "GB_UpdateTicket";
            this.GB_UpdateTicket.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_UpdateTicket.Size = new System.Drawing.Size(780, 410);
            this.GB_UpdateTicket.TabIndex = 11;
            this.GB_UpdateTicket.TabStop = false;
            this.GB_UpdateTicket.Text = "Update Ticket";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Selected.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Selected.RowHeadersVisible = false;
            this.DGV_Selected.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.DGV_Selected.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            this.BTN_cancel.Location = new System.Drawing.Point(414, 358);
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
            this.BTN_Update.Location = new System.Drawing.Point(652, 358);
            this.BTN_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(122, 29);
            this.BTN_Update.TabIndex = 12;
            this.BTN_Update.Text = "Update";
            this.BTN_Update.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Selected)).EndInit();
            this.PNLmain.ResumeLayout(false);
            this.PNLmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).EndInit();
            this.GB_Close.ResumeLayout(false);
            this.GB_Close.PerformLayout();
            this.GB_Escalate.ResumeLayout(false);
            this.GB_Escalate.PerformLayout();
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
        private System.Windows.Forms.PictureBox PBOX;
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
    }
}