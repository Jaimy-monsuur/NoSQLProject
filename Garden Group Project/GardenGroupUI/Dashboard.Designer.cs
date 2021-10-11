
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
            this.Pnl_IncidentenOverDatum = new System.Windows.Forms.Panel();
            this.formsPlot_Unresolved = new ScottPlot.FormsPlot();
            this.formsPlot_PastDeadline = new ScottPlot.FormsPlot();
            this.Lbl_Unresolved = new System.Windows.Forms.Label();
            this.Lbl_PastDeadLine = new System.Windows.Forms.Label();
            this.Lbl_Currentincidents = new System.Windows.Forms.Label();
            this.Btn_Incidents = new System.Windows.Forms.Button();
            this.Pnl_Openstaandeincidenten.SuspendLayout();
            this.Pnl_IncidentenOverDatum.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Openstaandeincidenten
            // 
            this.Pnl_Openstaandeincidenten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Openstaandeincidenten.Controls.Add(this.Lbl_Unresolved);
            this.Pnl_Openstaandeincidenten.Controls.Add(this.formsPlot_Unresolved);
            this.Pnl_Openstaandeincidenten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pnl_Openstaandeincidenten.Location = new System.Drawing.Point(79, 151);
            this.Pnl_Openstaandeincidenten.Name = "Pnl_Openstaandeincidenten";
            this.Pnl_Openstaandeincidenten.Size = new System.Drawing.Size(355, 351);
            this.Pnl_Openstaandeincidenten.TabIndex = 0;
            // 
            // Pnl_IncidentenOverDatum
            // 
            this.Pnl_IncidentenOverDatum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_IncidentenOverDatum.Controls.Add(this.Lbl_PastDeadLine);
            this.Pnl_IncidentenOverDatum.Controls.Add(this.formsPlot_PastDeadline);
            this.Pnl_IncidentenOverDatum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pnl_IncidentenOverDatum.Location = new System.Drawing.Point(562, 155);
            this.Pnl_IncidentenOverDatum.Name = "Pnl_IncidentenOverDatum";
            this.Pnl_IncidentenOverDatum.Size = new System.Drawing.Size(355, 351);
            this.Pnl_IncidentenOverDatum.TabIndex = 1;
            // 
            // formsPlot_Unresolved
            // 
            this.formsPlot_Unresolved.BackColor = System.Drawing.Color.Transparent;
            this.formsPlot_Unresolved.Location = new System.Drawing.Point(4, 63);
            this.formsPlot_Unresolved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot_Unresolved.Name = "formsPlot_Unresolved";
            this.formsPlot_Unresolved.Size = new System.Drawing.Size(345, 283);
            this.formsPlot_Unresolved.TabIndex = 0;
            // 
            // formsPlot_PastDeadline
            // 
            this.formsPlot_PastDeadline.BackColor = System.Drawing.Color.Transparent;
            this.formsPlot_PastDeadline.Location = new System.Drawing.Point(-1, 63);
            this.formsPlot_PastDeadline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot_PastDeadline.Name = "formsPlot_PastDeadline";
            this.formsPlot_PastDeadline.Size = new System.Drawing.Size(345, 283);
            this.formsPlot_PastDeadline.TabIndex = 1;
            // 
            // Lbl_Unresolved
            // 
            this.Lbl_Unresolved.AutoSize = true;
            this.Lbl_Unresolved.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Unresolved.Location = new System.Drawing.Point(50, 30);
            this.Lbl_Unresolved.Name = "Lbl_Unresolved";
            this.Lbl_Unresolved.Size = new System.Drawing.Size(218, 30);
            this.Lbl_Unresolved.TabIndex = 1;
            this.Lbl_Unresolved.Text = "Unresolved incidents";
            // 
            // Lbl_PastDeadLine
            // 
            this.Lbl_PastDeadLine.AutoSize = true;
            this.Lbl_PastDeadLine.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PastDeadLine.Location = new System.Drawing.Point(44, 27);
            this.Lbl_PastDeadLine.Name = "Lbl_PastDeadLine";
            this.Lbl_PastDeadLine.Size = new System.Drawing.Size(240, 30);
            this.Lbl_PastDeadLine.TabIndex = 2;
            this.Lbl_PastDeadLine.Text = "Incidents past deadline";
            // 
            // Lbl_Currentincidents
            // 
            this.Lbl_Currentincidents.AutoSize = true;
            this.Lbl_Currentincidents.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Currentincidents.Location = new System.Drawing.Point(79, 87);
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
            this.Btn_Incidents.Location = new System.Drawing.Point(779, 69);
            this.Btn_Incidents.Name = "Btn_Incidents";
            this.Btn_Incidents.Size = new System.Drawing.Size(138, 55);
            this.Btn_Incidents.TabIndex = 3;
            this.Btn_Incidents.Text = "ShowList";
            this.Btn_Incidents.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 549);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Openstaandeincidenten;
        private System.Windows.Forms.Label Lbl_Unresolved;
        private ScottPlot.FormsPlot formsPlot_Unresolved;
        private System.Windows.Forms.Panel Pnl_IncidentenOverDatum;
        private System.Windows.Forms.Label Lbl_PastDeadLine;
        private ScottPlot.FormsPlot formsPlot_PastDeadline;
        private System.Windows.Forms.Label Lbl_Currentincidents;
        private System.Windows.Forms.Button Btn_Incidents;
    }
}