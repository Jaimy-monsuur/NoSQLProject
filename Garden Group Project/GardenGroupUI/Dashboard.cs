using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GardenGroupUI
{
    public partial class Dashboard : Form
    {
        public int incidentOpenCount;
        public int incidentClosedCount;
        public int incidentcountpastdeadline;
        public int incidentcountOnTime;
        public int incidentcount;
        public List<Incident_Ticket> tickets;
        public List<Incident_Ticket> ticketsPastdeadline;
        public Dashboard()
        {
            InitializeComponent();
            Alltickets();
            OpenTickets();
            Pastdeadline();
            PiechartUnresolved();
            PiechartPastDeadline();
        }
        public void PiechartUnresolved()
        {
            double[] values = { incidentClosedCount, incidentOpenCount };
            Color color1 = Color.FromArgb(255, 0, 150, 200);
            Color color2 = Color.FromArgb(100, 0, 150, 200);
            var pie = FormsPlot_Unresolved.Plot.AddPie(values);
            pie.DonutSize = .6;
            pie.DonutLabel = $"{incidentOpenCount}/{incidentcount}";
            pie.CenterFont.Color = color1;
            pie.OutlineSize = 2;
            pie.SliceFillColors = new Color[] { color1, color2 };
            FormsPlot_Unresolved.Refresh();
            FormsPlot_Unresolved.Plot.SaveFig("pie_donutText.png");
        }
        public void PiechartPastDeadline()
        {
            double[] values = { incidentcountpastdeadline, incidentcountOnTime };
            Color color1 = Color.FromArgb(120, 255, 0, 0);
            Color color2 = Color.FromArgb(100, 0, 150, 200);
            var pie = FormsPlot_PastDealdine.Plot.AddPie(values);
            pie.DonutSize = .6;
            pie.DonutLabel = $"{incidentcountpastdeadline}/{incidentcount}";
            pie.CenterFont.Color = color1;
            pie.OutlineSize = 2;
            pie.SliceFillColors = new Color[] { color1, color2 };
            FormsPlot_PastDealdine.Refresh();
            FormsPlot_PastDealdine.Plot.SaveFig("pie_donutText.png");
        }
        public void OpenTickets()
        {
            incidentOpenCount = 0;
            Incident_TicketDAL insident_TicketDAL = new Incident_TicketDAL();
            tickets = insident_TicketDAL.GetAllTicketsWithStatusOpen();
            foreach (Incident_Ticket item in tickets)
            {
                if (item.Status == Incident_Status.Open)
                {
                    incidentOpenCount++;
                }
                else
                {
                    incidentClosedCount++;
                }
            }
        }
        public void Alltickets()
        {
            Incident_TicketDAL insident_TicketDAL = new Incident_TicketDAL();
            tickets = insident_TicketDAL.GetAllTickets();
            foreach (Incident_Ticket item in tickets)
            {
                incidentcount++;
            }
        }
        public void Pastdeadline()
        {
            incidentcountpastdeadline = 0;
            Incident_TicketDAL insident_TicketDAL = new Incident_TicketDAL();
            ticketsPastdeadline = insident_TicketDAL.GetAllTicketsWithDeadline();
            foreach (Incident_Ticket item in ticketsPastdeadline)
            {
                if (item.Deadline < DateTime.Now)
                {
                    incidentcountpastdeadline++;
                }
                else
                {
                    incidentcountOnTime++;
                }
            }
        }

        private void Btn_logOut_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void Btn_Incidents_Click(object sender, EventArgs e)
        {
            Incident_Management ticketform = new Incident_Management();
            ticketform.Show();
            this.Visible = false;
        }
    }
}
