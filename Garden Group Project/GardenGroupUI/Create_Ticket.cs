using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;
using Logic_Layer;

namespace GardenGroupUI
{
    public partial class Create_Ticket : Form
    {
        Incident_Ticket latest_Ticket;
        Incident_TickedLogic logic = new Incident_TickedLogic();

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
            latest_Ticket = logic.GetMaxId()[0];
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Menu.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void PNLmain_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, PNLmain.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            try
            {
                Incident_Ticket t = new Incident_Ticket();
                //tijdelijkt
                t = latest_Ticket;
                t.id += 1;
                logic.AddTicket(t);
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
