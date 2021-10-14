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
            try
            {
                //alle forms behalve de log in form sluiten.
                foreach (Form f in Application.OpenForms)
                    f.Close();
            }
            catch (Exception)
            {

            }

        }

        private void BTN_annuleer_Click(object sender, EventArgs e)
        {
            //niet uitloggen. sluit form
            this.Close();
        }
    }
}
