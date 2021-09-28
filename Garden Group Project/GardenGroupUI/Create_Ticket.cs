using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GardenGroupUI
{
    public partial class Create_Ticket : Form
    {
        public Create_Ticket()
        {
            InitializeComponent();
        }

        private void Create_Ticket_Load(object sender, EventArgs e)
        {
            // sets size of menu
            foreach (ToolStripItem item in Menu.Items)
            {
                item.Size = new Size(415, 24);
            }
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Menu.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void PNLmain_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, PNLmain.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }


    }
}
