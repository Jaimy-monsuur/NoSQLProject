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
        public User user;
        public User_Logic user_logic = new User_Logic();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Haal username op
            string email = txtEmail.Text;
            //Haal Password op en encrypt deze
            byte[] encodedPasswordArray = new byte[txtWachtwoord.Text.Length];
            encodedPasswordArray = System.Text.Encoding.UTF8.GetBytes(txtWachtwoord.Text);
            string password = Convert.ToBase64String(encodedPasswordArray);

            //Zoek de database naar een gebruiker met deze gebruikersnaam
            List <User> userList = user_logic.GetUser(email);
            User user = userList[0];

            //kijk of het wachtwoord klopt
            if (user.password == password)
            {
                //Indien het klopt, de gebruiker het juiste form laten zien
                switch (user.userType)
                {
                    case User_Type.Admin:
                        this.Hide();
                        Incident_Management incident_Management = new Incident_Management();
                        incident_Management.Show();// tijdelijk
                        break;
                    case User_Type.ServiceDeskEmployee:
                        this.Hide();
                        Dashboard ashboardForm = new Dashboard();
                        ashboardForm.Show();
                        break;
                    case User_Type.Employee:
                        this.Hide();
                        Dashboard shboardForm = new Dashboard();
                        shboardForm.Show();
                        break;
                }
            }
            else
            {
                //Indien het niet klopt, text laten zien, de user op null zetten en password-veld clearen
                user = null;
                lblWrongPW.Show();
                txtWachtwoord.Text = "";
            }
        }

        private void lnklblForgotPassWord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgotPassword forgotPassword = new frmForgotPassword();
            forgotPassword.Show();
        }

        private void txtGebruikersnaam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
