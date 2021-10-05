using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logic_Layer;
using Model;

namespace GardenGroupUI
{
    public partial class Incident_Management : Form
    {
        public Incident_TickedLogic logic_Layer = new Incident_TickedLogic();

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
            // sets size of menu
            foreach (ToolStripItem item in Menu.Items)
            {
                item.Size = new Size(415,24);
            }
            //for the default text in textbox
            this.TBXfilter.Enter += new EventHandler(TBXfilter_Enter);
            this.TBXfilter.Leave += new EventHandler(TBXfilter_Leave);
            TBXfilter_SetText();
            SetListvieuw();
            GetLVData();
        }

        protected void SetListvieuw()
        {
            // Maak grid
            LVTickets.Clear();
            LVTickets.View = View.Details;
            LVTickets.GridLines = true;
            LVTickets.FullRowSelect = true;

            // Voeg column header toe
            LVTickets.Columns.Add("Id:", 50);
            LVTickets.Columns.Add("Subject:", 400);
            LVTickets.Columns.Add("User:", 260);
            LVTickets.Columns.Add("Report date:", 110);
            LVTickets.Columns.Add("Deadline:", 100);
            LVTickets.Columns.Add("Status:", 100);
        }
        protected void GetLVData()
        {
            List<Incident_Ticket> list = logic_Layer.GetAllTickets();
            foreach (Incident_Ticket item in list)
            {
                string[] collumnItems = new string[6];
                collumnItems[0] = item.id.ToString();
                collumnItems[1] = item.subjectOfIncident;
                collumnItems[2] = item.ReportedBy;
                collumnItems[3] = item.reportDate.ToShortDateString();
                collumnItems[4] = item.Deadline.ToShortDateString();
                collumnItems[5] = item.Status;
                ListViewItem li = new ListViewItem(collumnItems);
                li.Tag = item;// zodat je het object terug kan vinden
                LVTickets.Items.Add(li);
            }
        }

        //for the defoult text in a text box
        protected void TBXfilter_SetText()
        {
            this.TBXfilter.Text = "Filter by email";
            TBXfilter.ForeColor = Color.Gray;
        }

        private void TBXfilter_Enter(object sender, EventArgs e)// haalt de default text weg als je gaat typen
        {
            if (TBXfilter.ForeColor == Color.Black)
                return;
            TBXfilter.Text = "";
            TBXfilter.ForeColor = Color.Black;
        }
        private void TBXfilter_Leave(object sender, EventArgs e)// plaatst de default text terug als je het leeg laat
        {
            if (TBXfilter.Text.Trim() == "")
                TBXfilter_SetText();
        }

        private void BTNaddTicket_Click(object sender, EventArgs e)
        {
            //Create_Ticket create_Ticket = new Create_Ticket();
            this.Hide();
            //create_Ticket.ShowDialog();
            this.Show();
        }
    }
}
