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
                    logic.AddTicket(t);
                    this.Close();
                }
            }
            catch (Exception)
            {
                LBL_Error.Text = "An unexpecter error has occurred";
            }
        }
    }
}
