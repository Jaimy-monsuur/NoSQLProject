
namespace GardenGroupUI
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBLLicense = new System.Windows.Forms.Label();
            this.LBLnodesk = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.Label();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.lblLoginWachtwoord = new System.Windows.Forms.Label();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnklblHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LBLLicense
            // 
            this.LBLLicense.AutoSize = true;
            this.LBLLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLLicense.Location = new System.Drawing.Point(850, 474);
            this.LBLLicense.Name = "LBLLicense";
            this.LBLLicense.Size = new System.Drawing.Size(242, 21);
            this.LBLLicense.TabIndex = 5;
            this.LBLLicense.Text = "Licensed to: The Garden Group";
            // 
            // LBLnodesk
            // 
            this.LBLnodesk.AutoSize = true;
            this.LBLnodesk.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLnodesk.Location = new System.Drawing.Point(964, 433);
            this.LBLnodesk.Name = "LBLnodesk";
            this.LBLnodesk.Size = new System.Drawing.Size(128, 41);
            this.LBLnodesk.TabIndex = 4;
            this.LBLnodesk.Text = "NoDesk";
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLogin.Location = new System.Drawing.Point(364, 78);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(415, 65);
            this.txtLogin.TabIndex = 6;
            this.txtLogin.Text = "Login bij NoDesk";
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGebruikersnaam.Location = new System.Drawing.Point(364, 202);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(150, 25);
            this.lblGebruikersnaam.TabIndex = 8;
            this.lblGebruikersnaam.Text = "Gebruikersnaam";
            // 
            // lblLoginWachtwoord
            // 
            this.lblLoginWachtwoord.AutoSize = true;
            this.lblLoginWachtwoord.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginWachtwoord.Location = new System.Drawing.Point(364, 257);
            this.lblLoginWachtwoord.Name = "lblLoginWachtwoord";
            this.lblLoginWachtwoord.Size = new System.Drawing.Size(119, 25);
            this.lblLoginWachtwoord.TabIndex = 9;
            this.lblLoginWachtwoord.Text = "Wachtwoord";
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.BackColor = System.Drawing.SystemColors.Window;
            this.txtGebruikersnaam.Location = new System.Drawing.Point(605, 202);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(174, 23);
            this.txtGebruikersnaam.TabIndex = 11;
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(605, 257);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(174, 23);
            this.txtWachtwoord.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(605, 299);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 23);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnklblHelp
            // 
            this.lnklblHelp.AutoSize = true;
            this.lnklblHelp.LinkColor = System.Drawing.Color.Blue;
            this.lnklblHelp.Location = new System.Drawing.Point(737, 303);
            this.lnklblHelp.Name = "lnklblHelp";
            this.lnklblHelp.Size = new System.Drawing.Size(32, 15);
            this.lnklblHelp.TabIndex = 14;
            this.lnklblHelp.TabStop = true;
            this.lnklblHelp.Text = "Help";
            this.lnklblHelp.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.lnklblHelp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Controls.Add(this.lblLoginWachtwoord);
            this.Controls.Add(this.lblGebruikersnaam);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.LBLLicense);
            this.Controls.Add(this.LBLnodesk);
            this.Name = "frmLogin";
            this.Text = "Garden Group Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLLicense;
        private System.Windows.Forms.Label LBLnodesk;
        private System.Windows.Forms.Label txtLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PBOX;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.Label lblLoginWachtwoord;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnklblHelp;
    }
}

