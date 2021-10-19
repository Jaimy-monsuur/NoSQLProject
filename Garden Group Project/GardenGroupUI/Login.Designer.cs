
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
            this.lblemail = new System.Windows.Forms.Label();
            this.lblLoginWachtwoord = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnklblForgotPassWord = new System.Windows.Forms.LinkLabel();
            this.lblWrongPW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLLicense
            // 
            this.LBLLicense.AutoSize = true;
            this.LBLLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLLicense.Location = new System.Drawing.Point(1005, 654);
            this.LBLLicense.Name = "LBLLicense";
            this.LBLLicense.Size = new System.Drawing.Size(242, 21);
            this.LBLLicense.TabIndex = 5;
            this.LBLLicense.Text = "Licensed to: The Garden Group";
            // 
            // LBLnodesk
            // 
            this.LBLnodesk.AutoSize = true;
            this.LBLnodesk.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLnodesk.Location = new System.Drawing.Point(1124, 616);
            this.LBLnodesk.Name = "LBLnodesk";
            this.LBLnodesk.Size = new System.Drawing.Size(128, 41);
            this.LBLnodesk.TabIndex = 4;
            this.LBLnodesk.Text = "NoDesk";
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLogin.Location = new System.Drawing.Point(425, 175);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(415, 65);
            this.txtLogin.TabIndex = 6;
            this.txtLogin.Text = "Login bij NoDesk";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblemail.Location = new System.Drawing.Point(382, 280);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(58, 25);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "Email";
            // 
            // lblLoginWachtwoord
            // 
            this.lblLoginWachtwoord.AutoSize = true;
            this.lblLoginWachtwoord.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginWachtwoord.Location = new System.Drawing.Point(382, 359);
            this.lblLoginWachtwoord.Name = "lblLoginWachtwoord";
            this.lblLoginWachtwoord.Size = new System.Drawing.Size(119, 25);
            this.lblLoginWachtwoord.TabIndex = 9;
            this.lblLoginWachtwoord.Text = "Wachtwoord";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(382, 308);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(500, 29);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtGebruikersnaam_TextChanged);
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWachtwoord.Location = new System.Drawing.Point(382, 387);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.PasswordChar = '*';
            this.txtWachtwoord.Size = new System.Drawing.Size(500, 29);
            this.txtWachtwoord.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(545, 463);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(174, 34);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnklblForgotPassWord
            // 
            this.lnklblForgotPassWord.AutoSize = true;
            this.lnklblForgotPassWord.LinkColor = System.Drawing.Color.Blue;
            this.lnklblForgotPassWord.Location = new System.Drawing.Point(568, 511);
            this.lnklblForgotPassWord.Name = "lnklblForgotPassWord";
            this.lnklblForgotPassWord.Size = new System.Drawing.Size(129, 15);
            this.lnklblForgotPassWord.TabIndex = 14;
            this.lnklblForgotPassWord.TabStop = true;
            this.lnklblForgotPassWord.Text = "Wachtwoord vergeten?";
            this.lnklblForgotPassWord.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnklblForgotPassWord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblForgotPassWord_LinkClicked);
            // 
            // lblWrongPW
            // 
            this.lblWrongPW.AutoSize = true;
            this.lblWrongPW.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblWrongPW.ForeColor = System.Drawing.Color.Red;
            this.lblWrongPW.Location = new System.Drawing.Point(407, 432);
            this.lblWrongPW.Name = "lblWrongPW";
            this.lblWrongPW.Size = new System.Drawing.Size(450, 15);
            this.lblWrongPW.TabIndex = 15;
            this.lblWrongPW.Text = "De door u opgegeven combinatie van gebruikersnaam en/of wachtwoord is ongeldig";
            this.lblWrongPW.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblWrongPW);
            this.Controls.Add(this.lnklblForgotPassWord);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblLoginWachtwoord);
            this.Controls.Add(this.lblemail);
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
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblLoginWachtwoord;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnklblForgotPassWord;
        private System.Windows.Forms.Label lblWrongPW;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

