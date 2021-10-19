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
            ProgressBar();
            Pastdeadline();
        }
        public void ProgressBar()
        {
            var plt = new ScottPlot.Plot(600, 400);

            double[] values = { 779, 586 };
            string centerText = $"{values[0] / values.Sum() * 100:00.0}%";
            Color color1 = Color.FromArgb(255, 0, 150, 200);
            Color color2 = Color.FromArgb(100, 0, 150, 200);

            var pie = plt.AddPie(values);
            pie.DonutSize = .6;
            pie.DonutLabel = centerText;
            pie.CenterFont.Color = color1;
            pie.OutlineSize = 2;
            pie.SliceFillColors = new Color[] { color1, color2 };

            plt.SaveFig("pie_donutText.png");

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

        private void Btn_Incidents_Click(object sender, EventArgs e)
        {
            Incident_Management incident_Management = new Incident_Management();
            incident_Management.Show();
            this.Close();
        }
    }
}
