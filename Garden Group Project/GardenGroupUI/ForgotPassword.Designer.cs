
namespace GardenGroupUI
{
    partial class frmForgotPassword
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblWachtwoordVergeten = new System.Windows.Forms.Label();
            this.LBLLicense = new System.Windows.Forms.Label();
            this.LBLnodesk = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.grbxEmail = new System.Windows.Forms.GroupBox();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.grbxVerification = new System.Windows.Forms.GroupBox();
            this.btnTryCode = new System.Windows.Forms.Button();
            this.lblYourNewPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblWrongCode = new System.Windows.Forms.Label();
            this.grbxEmail.SuspendLayout();
            this.grbxVerification.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(74, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(335, 29);
            this.txtEmail.TabIndex = 19;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCode.Location = new System.Drawing.Point(6, 35);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(179, 25);
            this.lblCode.TabIndex = 18;
            this.lblCode.Text = "Toegestuurde Code:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(6, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 25);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // lblWachtwoordVergeten
            // 
            this.lblWachtwoordVergeten.AutoSize = true;
            this.lblWachtwoordVergeten.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWachtwoordVergeten.Location = new System.Drawing.Point(367, 126);
            this.lblWachtwoordVergeten.Name = "lblWachtwoordVergeten";
            this.lblWachtwoordVergeten.Size = new System.Drawing.Size(530, 65);
            this.lblWachtwoordVergeten.TabIndex = 16;
            this.lblWachtwoordVergeten.Text = "Wachtwoord vergeten";
            // 
            // LBLLicense
            // 
            this.LBLLicense.AutoSize = true;
            this.LBLLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLLicense.Location = new System.Drawing.Point(1005, 654);
            this.LBLLicense.Name = "LBLLicense";
            this.LBLLicense.Size = new System.Drawing.Size(242, 21);
            this.LBLLicense.TabIndex = 23;
            this.LBLLicense.Text = "Licensed to: The Garden Group";
            // 
            // LBLnodesk
            // 
            this.LBLnodesk.AutoSize = true;
            this.LBLnodesk.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLnodesk.Location = new System.Drawing.Point(1124, 616);
            this.LBLnodesk.Name = "LBLnodesk";
            this.LBLnodesk.Size = new System.Drawing.Size(128, 41);
            this.LBLnodesk.TabIndex = 22;
            this.LBLnodesk.Text = "NoDesk";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(191, 35);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(218, 29);
            this.txtCode.TabIndex = 24;
            // 
            // grbxEmail
            // 
            this.grbxEmail.Controls.Add(this.btnBackToLogin);
            this.grbxEmail.Controls.Add(this.btnSendEmail);
            this.grbxEmail.Controls.Add(this.lblEmail);
            this.grbxEmail.Controls.Add(this.txtEmail);
            this.grbxEmail.Location = new System.Drawing.Point(417, 220);
            this.grbxEmail.Name = "grbxEmail";
            this.grbxEmail.Size = new System.Drawing.Size(426, 120);
            this.grbxEmail.TabIndex = 25;
            this.grbxEmail.TabStop = false;
            this.grbxEmail.Text = "Email";
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Location = new System.Drawing.Point(74, 70);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(165, 29);
            this.btnBackToLogin.TabIndex = 27;
            this.btnBackToLogin.Text = "Terug naar login";
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(245, 70);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(164, 29);
            this.btnSendEmail.TabIndex = 20;
            this.btnSendEmail.Text = "Verstuur email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // grbxVerification
            // 
            this.grbxVerification.Controls.Add(this.lblWrongCode);
            this.grbxVerification.Controls.Add(this.btnTryCode);
            this.grbxVerification.Controls.Add(this.lblCode);
            this.grbxVerification.Controls.Add(this.txtCode);
            this.grbxVerification.Location = new System.Drawing.Point(417, 346);
            this.grbxVerification.Name = "grbxVerification";
            this.grbxVerification.Size = new System.Drawing.Size(426, 133);
            this.grbxVerification.TabIndex = 26;
            this.grbxVerification.TabStop = false;
            this.grbxVerification.Text = "Verificatie";
            this.grbxVerification.Visible = false;
            // 
            // btnTryCode
            // 
            this.btnTryCode.Enabled = false;
            this.btnTryCode.Location = new System.Drawing.Point(300, 70);
            this.btnTryCode.Name = "btnTryCode";
            this.btnTryCode.Size = new System.Drawing.Size(109, 29);
            this.btnTryCode.TabIndex = 0;
            this.btnTryCode.Text = "Probeer code";
            this.btnTryCode.Click += new System.EventHandler(this.btnTryCode_Click);
            // 
            // lblYourNewPassword
            // 
            this.lblYourNewPassword.AutoSize = true;
            this.lblYourNewPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYourNewPassword.Location = new System.Drawing.Point(423, 530);
            this.lblYourNewPassword.Name = "lblYourNewPassword";
            this.lblYourNewPassword.Size = new System.Drawing.Size(239, 25);
            this.lblYourNewPassword.TabIndex = 27;
            this.lblYourNewPassword.Text = "Uw nieuwe Wachtwoord is:";
            this.lblYourNewPassword.Visible = false;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewPassword.Location = new System.Drawing.Point(693, 530);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(133, 25);
            this.lblNewPassword.TabIndex = 28;
            this.lblNewPassword.Text = "DITIS12CHARS";
            this.lblNewPassword.Visible = false;
            // 
            // lblWrongCode
            // 
            this.lblWrongCode.AutoSize = true;
            this.lblWrongCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblWrongCode.ForeColor = System.Drawing.Color.Red;
            this.lblWrongCode.Location = new System.Drawing.Point(15, 77);
            this.lblWrongCode.Name = "lblWrongCode";
            this.lblWrongCode.Size = new System.Drawing.Size(243, 30);
            this.lblWrongCode.TabIndex = 29;
            this.lblWrongCode.Text = "U heeft 3 keer een verkeerde code ingevoerd, \r\neen nieuwe code is naar u toe gest" +
    "uurd";
            this.lblWrongCode.Visible = false;
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblYourNewPassword);
            this.Controls.Add(this.grbxVerification);
            this.Controls.Add(this.grbxEmail);
            this.Controls.Add(this.LBLLicense);
            this.Controls.Add(this.LBLnodesk);
            this.Controls.Add(this.lblWachtwoordVergeten);
            this.Name = "frmForgotPassword";
            this.Text = "Wachtwoord Vergeten";
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            this.grbxEmail.ResumeLayout(false);
            this.grbxEmail.PerformLayout();
            this.grbxVerification.ResumeLayout(false);
            this.grbxVerification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblWachtwoordVergeten;
        private System.Windows.Forms.Label LBLLicense;
        private System.Windows.Forms.Label LBLnodesk;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.GroupBox grbxEmail;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.GroupBox grbxVerification;
        private System.Windows.Forms.Button btnTryCode;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Label lblYourNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblWrongPW;
        private System.Windows.Forms.Label lblWrongCode;
    }
}