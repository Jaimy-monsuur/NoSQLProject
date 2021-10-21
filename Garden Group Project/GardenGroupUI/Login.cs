using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic_Layer;
using Model;

namespace GardenGroupUI
{
    public partial class frmLogin : Form
    {
        //User_logic declaren en een tempuser aanmaken die in het login form gebruikt kan worden
        private static User tempUser;
        private static User_Logic user_logic = new User_Logic();
        public frmLogin()
        {
            InitializeComponent();
        }

        //Elke keer dat het form laad de user uitloggen
        private void frmLogin_Load(object sender, EventArgs e)
        {
            Program.loggedInUser = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Haal email op
            string email = txtEmail.Text;

            //Haal Password op en encrypt deze
            byte[] encodedPasswordArray = new byte[txtWachtwoord.Text.Length];
            encodedPasswordArray = System.Text.Encoding.UTF8.GetBytes(txtWachtwoord.Text);
            string password = Convert.ToBase64String(encodedPasswordArray);

            //Kijk of dit emailadres in de database staat
            if (user_logic.VerifyEmail(email) == true)
            {
                //Haal de gebruiker op en controleer het wwachtwoord
                List<User> userList = user_logic.GetUser(email);
                tempUser = userList[0];
                checkPassword(password);
            }
            else
            {
                //Laat zien dat de combinatie van email en/of wachtwoord niet bekend is
                tempUser = null;
                lblWrongPW.Show();
                txtWachtwoord.Text = "";
            }        
        }            

        private void checkPassword(string password)
        {
            //kijk of het wachtwoord klopt
            if (tempUser.password == password)
            {                
                //Indien het klopt, de gebruiker inloggen
                logUserIn();
            }
            else
            {
                //Indien het niet klopt, text laten zien, de user op null zetten en password-veld clearen
                tempUser = null;
                lblWrongPW.Show();
                txtWachtwoord.Text = "";
            }
        }
        private void logUserIn()
        {
            //De tempuser overzetten naar een user die in het hele programma bereikbaar is
            Program.loggedInUser = tempUser;
            tempUser = null;
            //Laat het dashboard zien
            this.Hide();
            txtEmail.Clear();
            txtWachtwoord.Clear();
            Dashboard ashboardForm = new Dashboard();
            ashboardForm.Show();
        }

        //De link label "wachtwoord vergeten" het juiste form laten weergeven
        private void lnklblForgotPassWord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            frmForgotPassword forgotPassword = new frmForgotPassword(txtEmail.Text);
            txtEmail.Clear();
            txtWachtwoord.Clear();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
