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
        public Dashboard()
        {
            InitializeComponent();
            OpenTickets();
            Pastdeadline();
            Progressbar();
        }
        public void Progressbar()
        {
            double[] xs = { 1, 2, 3, 4, 5 };
            double[] ys = { 1, 4, 9, 16, 25 };
            var plt = new ScottPlot.Plot(400, 300);
            plt.AddScatter(xs, ys);
            plt.SaveFig("quickstart.png");
        }
        public void OpenTickets()
        {
            int incidentcount = 0;
            Incident_TicketDAL insident_TicketDAL = new Incident_TicketDAL();
            foreach (Incident_Ticket item in insident_TicketDAL.GetAllTicketsWithStatusOpen())
            {
                incidentcount++;
            }
            Lbl_OutputUnresolved.Text = incidentcount.ToString();
        }
        public void Pastdeadline()
        {
            int incidentcountpastdeadline = 0;
            Incident_TicketDAL insident_TicketDAL = new Incident_TicketDAL();
            foreach (Incident_Ticket item in insident_TicketDAL.GetAllTicketsWithDeadline())
            {
                if (item.Deadline < DateTime.Now)
                {
                    incidentcountpastdeadline++;
                }
            }
            Lbl_PastdeadlineOutput.Text = incidentcountpastdeadline.ToString();
        }

        private void Btn_logOut_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void Btn_Incidents_Click(object sender, EventArgs e)
        {

        }
    }
}
