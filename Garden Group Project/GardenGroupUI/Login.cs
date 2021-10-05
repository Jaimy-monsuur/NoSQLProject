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

namespace GardenGroupUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Haal username en Password op
            string username = txtGebruikersnaam.Text;
            byte[] encData_byte = new byte[txtWachtwoord.Text.Length];
            encData_byte = System.Text.Encoding.UTF8.GetBytes(txtWachtwoord.Text);
            string password = Convert.ToBase64String(encData_byte);
            //test encryption
            lblGebruikersnaam.Text = password;
        }
    }
}
