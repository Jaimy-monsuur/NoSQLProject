
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
            this.lblNonExistingEmail = new System.Windows.Forms.Label();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.grbxVerification = new System.Windows.Forms.GroupBox();
            this.lblWrongCode = new System.Windows.Forms.Label();
            this.btnTryCode = new System.Windows.Forms.Button();
            this.lblYourNewPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.grbxNewPW = new System.Windows.Forms.GroupBox();
            this.lblCopyPW = new System.Windows.Forms.Label();
            this.grbxEmail.SuspendLayout();
            this.grbxVerification.SuspendLayout();
            this.grbxNewPW.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(12, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(484, 29);
            this.txtEmail.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCode.Location = new System.Drawing.Point(6, 19);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(328, 25);
            this.lblCode.TabIndex = 18;
            this.lblCode.Text = "The code that has been mailed to you";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(6, 19);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(305, 25);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Emailaddress linked to the account";
            // 
            // lblWachtwoordVergeten
            // 
            this.lblWachtwoordVergeten.AutoSize = true;
            this.lblWachtwoordVergeten.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWachtwoordVergeten.Location = new System.Drawing.Point(421, 147);
            this.lblWachtwoordVergeten.Name = "lblWachtwoordVergeten";
            this.lblWachtwoordVergeten.Size = new System.Drawing.Size(406, 65);
            this.lblWachtwoordVergeten.TabIndex = 16;
            this.lblWachtwoordVergeten.Text = "Forgot password";
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
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(12, 47);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(314, 29);
            this.txtCode.TabIndex = 4;
            // 
            // grbxEmail
            // 
            this.grbxEmail.Controls.Add(this.lblNonExistingEmail);
            this.grbxEmail.Controls.Add(this.btnBackToLogin);
            this.grbxEmail.Controls.Add(this.btnSendEmail);
            this.grbxEmail.Controls.Add(this.lblEmail);
            this.grbxEmail.Controls.Add(this.txtEmail);
            this.grbxEmail.Location = new System.Drawing.Point(376, 233);
            this.grbxEmail.Name = "grbxEmail";
            this.grbxEmail.Size = new System.Drawing.Size(513, 122);
            this.grbxEmail.TabIndex = 25;
            this.grbxEmail.TabStop = false;
            this.grbxEmail.Text = "Email";
            // 
            // lblNonExistingEmail
            // 
            this.lblNonExistingEmail.AutoSize = true;
            this.lblNonExistingEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNonExistingEmail.ForeColor = System.Drawing.Color.Red;
            this.lblNonExistingEmail.Location = new System.Drawing.Point(12, 89);
            this.lblNonExistingEmail.Name = "lblNonExistingEmail";
            this.lblNonExistingEmail.Size = new System.Drawing.Size(265, 15);
            this.lblNonExistingEmail.TabIndex = 28;
            this.lblNonExistingEmail.Text = "This emailaddress does not exsist in our database";
            this.lblNonExistingEmail.Visible = false;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Location = new System.Drawing.Point(304, 82);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(85, 29);
            this.btnBackToLogin.TabIndex = 2;
            this.btnBackToLogin.Text = "Back to login";
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(395, 82);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(101, 29);
            this.btnSendEmail.TabIndex = 3;
            this.btnSendEmail.Text = "Send email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // grbxVerification
            // 
            this.grbxVerification.Controls.Add(this.lblWrongCode);
            this.grbxVerification.Controls.Add(this.btnTryCode);
            this.grbxVerification.Controls.Add(this.lblCode);
            this.grbxVerification.Controls.Add(this.txtCode);
            this.grbxVerification.Location = new System.Drawing.Point(376, 361);
            this.grbxVerification.Name = "grbxVerification";
            this.grbxVerification.Size = new System.Drawing.Size(513, 112);
            this.grbxVerification.TabIndex = 26;
            this.grbxVerification.TabStop = false;
            this.grbxVerification.Text = "Verification";
            this.grbxVerification.Visible = false;
            // 
            // lblWrongCode
            // 
            this.lblWrongCode.AutoSize = true;
            this.lblWrongCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblWrongCode.ForeColor = System.Drawing.Color.Red;
            this.lblWrongCode.Location = new System.Drawing.Point(12, 80);
            this.lblWrongCode.Name = "lblWrongCode";
            this.lblWrongCode.Size = new System.Drawing.Size(364, 15);
            this.lblWrongCode.TabIndex = 29;
            this.lblWrongCode.Text = "The wrong code has been entered 3 times, a new code has been sent";
            this.lblWrongCode.Visible = false;
            // 
            // btnTryCode
            // 
            this.btnTryCode.Location = new System.Drawing.Point(332, 48);
            this.btnTryCode.Name = "btnTryCode";
            this.btnTryCode.Size = new System.Drawing.Size(164, 29);
            this.btnTryCode.TabIndex = 5;
            this.btnTryCode.Text = "Try code";
            this.btnTryCode.Click += new System.EventHandler(this.btnTryCode_Click);
            // 
            // lblYourNewPassword
            // 
            this.lblYourNewPassword.AutoSize = true;
            this.lblYourNewPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYourNewPassword.Location = new System.Drawing.Point(27, 19);
            this.lblYourNewPassword.Name = "lblYourNewPassword";
            this.lblYourNewPassword.Size = new System.Drawing.Size(316, 25);
            this.lblYourNewPassword.TabIndex = 27;
            this.lblYourNewPassword.Text = "We have changed your password to:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewPassword.Location = new System.Drawing.Point(347, 19);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(133, 25);
            this.lblNewPassword.TabIndex = 28;
            this.lblNewPassword.Text = "DITIS12CHARS";
            this.lblNewPassword.Click += new System.EventHandler(this.lblNewPassword_Click);
            // 
            // grbxNewPW
            // 
            this.grbxNewPW.Controls.Add(this.lblCopyPW);
            this.grbxNewPW.Controls.Add(this.lblNewPassword);
            this.grbxNewPW.Controls.Add(this.lblYourNewPassword);
            this.grbxNewPW.Location = new System.Drawing.Point(376, 479);
            this.grbxNewPW.Name = "grbxNewPW";
            this.grbxNewPW.Size = new System.Drawing.Size(513, 74);
            this.grbxNewPW.TabIndex = 29;
            this.grbxNewPW.TabStop = false;
            this.grbxNewPW.Text = "New password";
            this.grbxNewPW.Visible = false;
            // 
            // lblCopyPW
            // 
            this.lblCopyPW.AutoSize = true;
            this.lblCopyPW.Location = new System.Drawing.Point(74, 44);
            this.lblCopyPW.Name = "lblCopyPW";
            this.lblCopyPW.Size = new System.Drawing.Size(364, 15);
            this.lblCopyPW.TabIndex = 29;
            this.lblCopyPW.Text = "Click on your new password to copy it and return to the login menu";
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grbxNewPW);
            this.Controls.Add(this.grbxVerification);
            this.Controls.Add(this.grbxEmail);
            this.Controls.Add(this.LBLLicense);
            this.Controls.Add(this.LBLnodesk);
            this.Controls.Add(this.lblWachtwoordVergeten);
            this.Name = "frmForgotPassword";
            this.Text = "Forgot password";
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            this.grbxEmail.ResumeLayout(false);
            this.grbxEmail.PerformLayout();
            this.grbxVerification.ResumeLayout(false);
            this.grbxVerification.PerformLayout();
            this.grbxNewPW.ResumeLayout(false);
            this.grbxNewPW.PerformLayout();
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
        private System.Windows.Forms.Label lblWrongCode;
        private System.Windows.Forms.GroupBox grbxNewPW;
        private System.Windows.Forms.Label lblCopyPW;
        private System.Windows.Forms.Label lblNonExistingEmail;
    }
}