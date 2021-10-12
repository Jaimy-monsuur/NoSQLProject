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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Create_Ticket_Load(object sender, EventArgs e)
        {
            latest_Ticket = logic.GetMaxId()[0];
            DTP_Deadline.MinDate = DateTime.Now;// deadline can not be in the past when creating a new ticket
            DTP_ReportDate.MinDate = DateTime.Now.AddDays(-7); // The report date can be a bit in the past but not in the future
            DTP_ReportDate.MaxDate = DateTime.Now;
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (DTP_ReportDate.Text != "" && TXB_Subject.Text != "" && CB_incidentType.Text != "" && CB_ReportedBy.Text != "" && CB_Priority.Text!= "" && DTP_Deadline.Text != "" && RTB_Description.Text != "" )
                {
                    Incident_Ticket t = new Incident_Ticket();
                    //tijdelijkt
                    t.id = latest_Ticket.id++;
                    t.reportDate = DateTime.Parse(DTP_ReportDate.Text);
                    t.subjectOfIncident = TXB_Subject.Text;
                    t.Incident_Type = (Incident_Type)Enum.Parse(typeof(Incident_Type), CB_incidentType.Text, true);
                    t.ReportedBy = CB_ReportedBy.Text;
                    t.Incident_Priority = (Incident_Priority)Enum.Parse(typeof(Incident_Priority), CB_Priority.Text, true);
                    t.Deadline = DateTime.Parse(DTP_Deadline.Text);
                    t.Description = RTB_Description.Text;
                    t.Status = Incident_Status.Open;

                    logic.AddTicket(t);
                    this.Close();
                }
                else
                {
                    LBL_Error.Text = "Fill in all fields";
                }
            }
            catch (Exception)
            {
                LBL_Error.Text = "An unexpecter error has occurred";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

    }
}
