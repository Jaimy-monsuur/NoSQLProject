
namespace GardenGroupUI
{
    partial class Dashboard
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
            this.Pnl_Openstaandeincidenten = new System.Windows.Forms.Panel();
            this.FormsPlot_Unresolved = new ScottPlot.FormsPlot();
            this.Lbl_Unresolved = new System.Windows.Forms.Label();
            this.Pnl_IncidentenOverDatum = new System.Windows.Forms.Panel();
            this.FormsPlot_PastDealdine = new ScottPlot.FormsPlot();
            this.Lbl_PastDeadLine = new System.Windows.Forms.Label();
            this.Lbl_Currentincidents = new System.Windows.Forms.Label();
            this.Btn_Incidents = new System.Windows.Forms.Button();
            this.PNLmain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_logOut = new System.Windows.Forms.Button();
            this.LBLnodesk = new System.Windows.Forms.Label();
            this.LBLLicense = new System.Windows.Forms.Label();
            this.PBOX = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl_Openstaandeincidenten.SuspendLayout();
            this.Pnl_IncidentenOverDatum.SuspendLayout();
            this.PNLmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Openstaandeincidenten
            // 
            this.Pnl_Openstaandeincidenten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Openstaandeincidenten.Controls.Add(this.FormsPlot_Unresolved);
            this.Pnl_Openstaandeincidenten.Controls.Add(this.Lbl_Unresolved);
            this.Pnl_Openstaandeincidenten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pnl_Openstaandeincidenten.Location = new System.Drawing.Point(161, 224);
            this.Pnl_Openstaandeincidenten.Name = "Pnl_Openstaandeincidenten";
            this.Pnl_Openstaandeincidenten.Size = new System.Drawing.Size(355, 351);
            this.Pnl_Openstaandeincidenten.TabIndex = 0;
            // 
            // FormsPlot_Unresolved
            // 
            this.FormsPlot_Unresolved.BackColor = System.Drawing.Color.Transparent;
            this.FormsPlot_Unresolved.Location = new System.Drawing.Point(-1, 64);
            this.FormsPlot_Unresolved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FormsPlot_Unresolved.Name = "FormsPlot_Unresolved";
            this.FormsPlot_Unresolved.Size = new System.Drawing.Size(355, 286);
            this.FormsPlot_Unresolved.TabIndex = 3;
            // 
            // Lbl_Unresolved
            // 
            this.Lbl_Unresolved.AutoSize = true;
            this.Lbl_Unresolved.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Unresolved.Location = new System.Drawing.Point(67, 26);
            this.Lbl_Unresolved.Name = "Lbl_Unresolved";
            this.Lbl_Unresolved.Size = new System.Drawing.Size(218, 30);
            this.Lbl_Unresolved.TabIndex = 1;
            this.Lbl_Unresolved.Text = "Unresolved incidents";
            // 
            // Pnl_IncidentenOverDatum
            // 
            this.Pnl_IncidentenOverDatum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_IncidentenOverDatum.Controls.Add(this.FormsPlot_PastDealdine);
            this.Pnl_IncidentenOverDatum.Controls.Add(this.Lbl_PastDeadLine);
            this.Pnl_IncidentenOverDatum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pnl_IncidentenOverDatum.Location = new System.Drawing.Point(732, 224);
            this.Pnl_IncidentenOverDatum.Name = "Pnl_IncidentenOverDatum";
            this.Pnl_IncidentenOverDatum.Size = new System.Drawing.Size(355, 351);
            this.Pnl_IncidentenOverDatum.TabIndex = 1;
            // 
            // FormsPlot_PastDealdine
            // 
            this.FormsPlot_PastDealdine.BackColor = System.Drawing.Color.Transparent;
            this.FormsPlot_PastDealdine.Location = new System.Drawing.Point(-1, 64);
            this.FormsPlot_PastDealdine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FormsPlot_PastDealdine.Name = "FormsPlot_PastDealdine";
            this.FormsPlot_PastDealdine.Size = new System.Drawing.Size(355, 286);
            this.FormsPlot_PastDealdine.TabIndex = 4;
            // 
            // Lbl_PastDeadLine
            // 
            this.Lbl_PastDeadLine.AutoSize = true;
            this.Lbl_PastDeadLine.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PastDeadLine.Location = new System.Drawing.Point(54, 26);
            this.Lbl_PastDeadLine.Name = "Lbl_PastDeadLine";
            this.Lbl_PastDeadLine.Size = new System.Drawing.Size(240, 30);
            this.Lbl_PastDeadLine.TabIndex = 2;
            this.Lbl_PastDeadLine.Text = "Incidents past deadline";
            // 
            // Lbl_Currentincidents
            // 
            this.Lbl_Currentincidents.AutoSize = true;
            this.Lbl_Currentincidents.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Currentincidents.Location = new System.Drawing.Point(161, 161);
            this.Lbl_Currentincidents.Name = "Lbl_Currentincidents";
            this.Lbl_Currentincidents.Size = new System.Drawing.Size(238, 37);
            this.Lbl_Currentincidents.TabIndex = 2;
            this.Lbl_Currentincidents.Text = "Current Incidents";
            // 
            // Btn_Incidents
            // 
            this.Btn_Incidents.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Incidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Incidents.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Incidents.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Btn_Incidents.Location = new System.Drawing.Point(949, 158);
            this.Btn_Incidents.Name = "Btn_Incidents";
            this.Btn_Incidents.Size = new System.Drawing.Size(138, 55);
            this.Btn_Incidents.TabIndex = 3;
            this.Btn_Incidents.Text = "ShowList";
            this.Btn_Incidents.UseVisualStyleBackColor = false;
            this.Btn_Incidents.Click += new System.EventHandler(this.Btn_Incidents_Click_1);
            // 
            // PNLmain
            // 
            this.PNLmain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLmain.AutoSize = true;
            this.PNLmain.BackColor = System.Drawing.Color.DarkCyan;
            this.PNLmain.Controls.Add(this.label2);
            this.PNLmain.Controls.Add(this.label1);
            this.PNLmain.Controls.Add(this.Btn_logOut);
            this.PNLmain.Controls.Add(this.LBLnodesk);
            this.PNLmain.Controls.Add(this.LBLLicense);
            this.PNLmain.Controls.Add(this.PBOX);
            this.PNLmain.Controls.Add(this.Menu);
            this.PNLmain.Location = new System.Drawing.Point(0, 0);
            this.PNLmain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PNLmain.Name = "PNLmain";
            this.PNLmain.Size = new System.Drawing.Size(1266, 111);
            this.PNLmain.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1010, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 41);
            this.label1.TabIndex = 29;
            this.label1.Text = "NoDesk";
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
            this.LBLnodesk.Location = new System.Drawing.Point(2190, 7);
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
            this.LBLLicense.Location = new System.Drawing.Point(2076, 59);
            this.LBLLicense.Name = "LBLLicense";
            this.LBLLicense.Size = new System.Drawing.Size(242, 21);
            this.LBLLicense.TabIndex = 2;
            this.LBLLicense.Text = "Licensed to: The Garden Group";
            // 
            // PBOX
            // 
            this.PBOX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PBOX.Location = new System.Drawing.Point(10, 9);
            this.PBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBOX.Name = "PBOX";
            this.PBOX.Size = new System.Drawing.Size(162, 72);
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
            // 
            // incidentManagementToolStripMenuItem
            // 
            this.incidentManagementToolStripMenuItem.AutoSize = false;
            this.incidentManagementToolStripMenuItem.Name = "incidentManagementToolStripMenuItem";
            this.incidentManagementToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.incidentManagementToolStripMenuItem.Text = "Incident management";
            this.incidentManagementToolStripMenuItem.Click += new System.EventHandler(this.incidentManagementToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.AutoSize = false;
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.userManagementToolStripMenuItem.Text = "User management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PNLmain);
            this.Controls.Add(this.Btn_Incidents);
            this.Controls.Add(this.Lbl_Currentincidents);
            this.Controls.Add(this.Pnl_IncidentenOverDatum);
            this.Controls.Add(this.Pnl_Openstaandeincidenten);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Pnl_Openstaandeincidenten.ResumeLayout(false);
            this.Pnl_Openstaandeincidenten.PerformLayout();
            this.Pnl_IncidentenOverDatum.ResumeLayout(false);
            this.Pnl_IncidentenOverDatum.PerformLayout();
            this.PNLmain.ResumeLayout(false);
            this.PNLmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Openstaandeincidenten;
        private System.Windows.Forms.Label Lbl_Unresolved;
        private System.Windows.Forms.Panel Pnl_IncidentenOverDatum;
        private System.Windows.Forms.Label Lbl_PastDeadLine;
        private System.Windows.Forms.Label Lbl_Currentincidents;
        private System.Windows.Forms.Button Btn_Incidents;
        private System.Windows.Forms.Panel PNLmain;
        private System.Windows.Forms.Button Btn_logOut;
        private System.Windows.Forms.Label LBLnodesk;
        private System.Windows.Forms.Label LBLLicense;
        private System.Windows.Forms.PictureBox PBOX;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ScottPlot.FormsPlot FormsPlot_Unresolved;
        private ScottPlot.FormsPlot FormsPlot_PastDealdine;
    }
}