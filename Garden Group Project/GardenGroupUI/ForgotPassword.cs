using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Web;

namespace GardenGroupUI
{
    public partial class frmForgotPassword : Form
    {
        string code;
        private int wrongTries = 0;
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {

        }
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            GenerateCode();
            SendEmail(txtEmail.Text, "Uw code om uw verzoek tot een nieuw wachtwoord te voltooien", $"Beste NoDesk gebruiker,\n\nHierbij de code voor het wijzigen van uw wachtwoord: {code}\n\nHet NoDesk team");
            grbxVerification.Show();
            btnTryCode.Enabled = true;
            txtCode.Enabled = true;
        }
        private void btnTryCode_Click(object sender, EventArgs e)
        {            
            if (txtCode.Text == code)
            {
                code = null;
                string newPassword = GeneratePassword();
                lblNewPassword.Text = newPassword;
                lblNewPassword.Show();
                new ToolTip().SetToolTip(lblNewPassword, "Klik op het wachtwoord om het te kopiëren");
                lblYourNewPassword.Show();
                //VERANDER HET WACHTWOORD IN DE DATABASE!
            }
            else
            {
                txtCode.Text = "";
                wrongTries++;
                if (wrongTries == 3)
                {
                    GenerateCode();
                    lblWrongCode.Show();
                    SendEmail(txtEmail.Text, "Een nieuwe code, speciaal voor u!", $"Beste NoDesk gebruiker,\n\nHierbij de nieuwe code voor het wijzigen van uw wachtwoord: {code}\n" +
                        $"U krijgt deze nieuwe code omdat u 3x de verkeerde code heeft ingevoerd tijdens uw verzoek voor een nieuw wachtwoord." +
                        $"\nDe oude code komt hierbij dus te vervallen.\n\nHet NoDesk team");
                    wrongTries = 0;
                }
            }
        }
        private void SendEmail(string recepient, string subject, string body)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("nodeskservice@gmail.com", ConfigurationManager.AppSettings.Get("password")),
                EnableSsl = true,
            };
            smtpClient.Send("nodeskservice@gmail.com", recepient, subject, body);
            //TRY CATCH VOOR EEN VERKEERD INGEBULD EMAIL ADRES
        }
        private void GenerateCode()
        {
            Random rnd = new Random();
            code = rnd.Next(0, 10).ToString();
            for (int i = 0; i < 6; i++)
            {
                code += rnd.Next(0, 10).ToString();
            }
        }
        private string GeneratePassword()
        {
            int length = 12;
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random rnd = new Random();
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[rnd.Next(0, validChars.Length)];
            }
            return new string(chars);
        }

        private void lblNewPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblNewPassword.Text);
        }
    }
}
