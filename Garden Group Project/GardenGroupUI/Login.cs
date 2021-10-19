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
        public User tempUser;
        public User_Logic user_logic = new User_Logic();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

            //Zoek de database naar een gebruiker met deze email
            List <User> userList = user_logic.GetUser(email);
            if (userList.Count == 1)
            {
                tempUser = userList[0];
                checkPassword(tempUser, password);
            }
            else
            {
                lblWrongPW.Show();
                txtWachtwoord.Text = "";
            }

            void checkPassword(User tempuser, string password)
            {
                //kijk of het wachtwoord klopt
                if (tempUser.password == password)
                {
                    Program.loggedInUser = tempUser;
                    tempUser = null;
                    //Indien het klopt, de gebruiker het juiste form laten zien
                    switch (Program.loggedInUser.userType)
                    {
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
                    tempUser = null;
                    lblWrongPW.Show();
                    txtWachtwoord.Text = "";
                }
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
