using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GardenGroupUI
{
    public partial class Incident_Management : Form
    {
        public Incident_Management()
        {
            InitializeComponent();
        }

        private void PNLmain_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, PNLmain.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Menu.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void Incident_Management_Load(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in Menu.Items)
            {
                item.Size = new Size(415,24);
            }
        }
    }
}
