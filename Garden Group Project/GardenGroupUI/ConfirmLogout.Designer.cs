
namespace GardenGroupUI
{
    partial class ConfirmLogout
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
            this.BTN_loguit = new System.Windows.Forms.Button();
            this.BTN_annuleer = new System.Windows.Forms.Button();
            this.LBL_Loguit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_loguit
            // 
            this.BTN_loguit.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_loguit.Location = new System.Drawing.Point(40, 108);
            this.BTN_loguit.Name = "BTN_loguit";
            this.BTN_loguit.Size = new System.Drawing.Size(139, 39);
            this.BTN_loguit.TabIndex = 0;
            this.BTN_loguit.Text = "Log out";
            this.BTN_loguit.UseVisualStyleBackColor = false;
            this.BTN_loguit.Click += new System.EventHandler(this.BTN_loguit_Click);
            // 
            // BTN_annuleer
            // 
            this.BTN_annuleer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_annuleer.Location = new System.Drawing.Point(253, 108);
            this.BTN_annuleer.Name = "BTN_annuleer";
            this.BTN_annuleer.Size = new System.Drawing.Size(139, 39);
            this.BTN_annuleer.TabIndex = 1;
            this.BTN_annuleer.Text = "Cancel";
            this.BTN_annuleer.UseVisualStyleBackColor = false;
            this.BTN_annuleer.Click += new System.EventHandler(this.BTN_annuleer_Click);
            // 
            // LBL_Loguit
            // 
            this.LBL_Loguit.AutoSize = true;
            this.LBL_Loguit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Loguit.Location = new System.Drawing.Point(139, 40);
            this.LBL_Loguit.Name = "LBL_Loguit";
            this.LBL_Loguit.Size = new System.Drawing.Size(155, 25);
            this.LBL_Loguit.TabIndex = 2;
            this.LBL_Loguit.Text = "Confirm Logout";
            // 
            // ConfirmLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(441, 181);
            this.Controls.Add(this.LBL_Loguit);
            this.Controls.Add(this.BTN_annuleer);
            this.Controls.Add(this.BTN_loguit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmLogout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfirmLogout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_loguit;
        private System.Windows.Forms.Button BTN_annuleer;
        private System.Windows.Forms.Label LBL_Loguit;
    }
}