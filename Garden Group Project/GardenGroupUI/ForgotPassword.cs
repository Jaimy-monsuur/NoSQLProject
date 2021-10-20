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
using Model;
using Logic_Layer;

namespace GardenGroupUI
{
    public partial class frmForgotPassword : Form
    {
        //Maak code en wrongtries aan zodat die overal in forgot password gebruikt kunnen worden
        //Code is een string zodat deze met 0 kan beginnen
        private static string code;
        private static int wrongTries = 0;
        private static User_Logic user_logic = new User_Logic();

        //Ctor voor een form met een al ingevulde email (zodat de user niet 2x zijn/haar wachtwoord in hoeft te vullen)
        public frmForgotPassword(string email)
        {
            InitializeComponent();
            txtEmail.Text = email;
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {

        }

        //Sluit het form en laat het login form zien
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin(txtEmail.Text);
            frmLogin.Show();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            //Kijk of het emailadres in de database staat
            if (user_logic.VerifyEmail(txtEmail.Text) == true)
            {
                //Maak een code en stuur een email met deze code
                GenerateCode();
                SendEmail(txtEmail.Text, "Uw code om uw verzoek tot een nieuw wachtwoord te voltooien", $"Beste NoDesk gebruiker,\n\nHierbij de code voor het wijzigen van uw wachtwoord: {code}\n\nHet NoDesk team");

                //Laat de volgdende stap zien
                grbxVerification.Show();
                lblNonExistingEmail.Hide();
            }
            else
            {
                //Laat zien dat het ingevoerde adres niet in onze database staat
                lblNonExistingEmail.Show();                    
            }
        }
        private void btnTryCode_Click(object sender, EventArgs e)
        {            
            //Kijk of de ingevulde code hetzelfde is als de code die het programma heeft gegenereerd
            if (txtCode.Text == code)
            {
                //Zet de code op 0 en maak een nieuwe wachtwoord voor de gebruiker
                code = null;
                wrongTries = 0;
                string newPassword = GeneratePassword();

                //Update het wachtwoord en laat het zien
                user_logic.UpdatePassword(txtEmail.Text, newPassword);
                lblNewPassword.Text = newPassword;
                grbxNewPW.Show();
                new ToolTip().SetToolTip(lblNewPassword, "Klik op het wachtwoord om het te kopiëren");               
            }
            else
            {
                //Maak de textbox voor de code leeg en voeg een verkeerde poging toe
                txtCode.Text = "";
                wrongTries++;

                //Kijk of het aantal verkeerde pogingen 3 is
                if (wrongTries == 3)
                {
                    //Maak een nieuwe code en stuur een nieuwe mail (om oneindig de code gokken te voorkomen)
                    GenerateCode();
                    lblWrongCode.Show();
                    SendEmail(txtEmail.Text, "Een nieuwe code, speciaal voor u!", $"Beste NoDesk gebruiker,\n\nHierbij de nieuwe code voor het wijzigen van uw wachtwoord: {code}\n" +
                        $"U krijgt deze nieuwe code omdat u 3x de verkeerde code heeft ingevoerd tijdens uw verzoek voor een nieuw wachtwoord." +
                        $"\nDe oude code komt hierbij dus te vervallen.\n\nHet NoDesk team");

                    //Zet wrongtries weer op 0
                    wrongTries = 0;
                }
            }
        }
        private void SendEmail(string recepient, string subject, string body)
        {
            //Maak een SMTP client aan die via de smtp server van google een mail kan sturen
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("nodeskservice@gmail.com", ConfigurationManager.AppSettings.Get("password")),
                EnableSsl = true,
            };

            //Verstuur de mail
            smtpClient.Send("nodeskservice@gmail.com", recepient, subject, body);
        }
        private void GenerateCode()
        {
            //Maak een 6-digit random code die verstuurt kan worden
            Random rnd = new Random();
            code = rnd.Next(0, 10).ToString();
            for (int i = 0; i < 6; i++)
            {
                code += rnd.Next(0, 10).ToString();
            }
        }
        private string GeneratePassword()
        {
            //Maak een wachtwoord van 12 karakters lang met de volgende mogelijke karakters
            int length = 12;
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";

            //Kies random karakters uit de string validChars en voeg deze toe aan een array
            Random rnd = new Random();
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[rnd.Next(0, validChars.Length)];
            }
            //Zet de array om in een string en return deze
            return new string(chars);
        }

        private void lblNewPassword_Click(object sender, EventArgs e)
        {
            //Kopieer het wachtwoord en ga terug naar de login pagina
            Clipboard.SetText(lblNewPassword.Text);
            this.Hide();
            frmLogin frmLogin = new frmLogin(txtEmail.Text);
            frmLogin.Show();
        }
    }
}
