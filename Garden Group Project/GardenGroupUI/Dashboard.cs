using DAL;
using Model;
using Logic_Layer;
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
        public Incident_TickedLogic logic_Layer = new Incident_TickedLogic();
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
            tickets = logic_Layer.GetOpenTickets();
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
            tickets = logic_Layer.GetAllTickets();
            foreach (Incident_Ticket item in tickets)
            {
                incidentcount++;
            }
        }
        public void Pastdeadline()
        {
            incidentcountpastdeadline = 0;
            ticketsPastdeadline = logic_Layer.GetDeadlineTickets();
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


        private void Btn_Incidents_Click_1(object sender, EventArgs e)
        {
            Incident_Management incident_Management = new Incident_Management();
            incident_Management.Show();
            this.Close();
        }
    }
}
