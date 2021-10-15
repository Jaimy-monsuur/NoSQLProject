using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GardenGroupUI
{
    public partial class ConfirmLogout : Form
    {
        public ConfirmLogout()
        {
            InitializeComponent();
        }

        private void BTN_loguit_Click(object sender, EventArgs e)
        {

            //alle forms behalve de log in form sluiten.
            List<Form> activeForms = new List<Form>();
            foreach (Form item in Application.OpenForms)
            {
                activeForms.Add(item);
            }

            foreach (Form f in activeForms)
            {
                if ( f.Name != "frmLogin")
                {
                    f.Close();
                }
                else 
                {
                    f.Show();
                }
            }
        }

        private void BTN_annuleer_Click(object sender, EventArgs e)
        {
            //niet uitloggen. sluit form
            this.Close();
        }
    }
}
