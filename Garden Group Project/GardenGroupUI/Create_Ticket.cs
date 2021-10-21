using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;
using Logic_Layer;
using System.IO;

namespace GardenGroupUI
{
    public partial class Create_Ticket : Form
    {
        Incident_Ticket latest_Ticket;
        Incident_TickedLogic incident_TickedLogic = new Incident_TickedLogic();
        User_Logic user_Logic = new User_Logic();

        public Create_Ticket()
        {
            InitializeComponent();
            this.MaximizeBox = false;// Size staat vast
        }

        private void Create_Ticket_Load(object sender, EventArgs e)
        {
            GetLatestTicket();
            DTP_Deadline.MinDate = DateTime.Now;// deadline can not be in the past when creating a new ticket
            DTP_ReportDate.MinDate = DateTime.Now.AddDays(-7); // The report date can be a bit in the past but not in the future
            DTP_ReportDate.MaxDate = DateTime.Now;
            ComboBoxSetting();
        }
        public void GetLatestTicket()// haalt ticket met hoogste id
        {
            try
            { 
                latest_Ticket = incident_TickedLogic.GetMaxId()[0];
            }
            catch (System.ArgumentOutOfRangeException)// als er geen tickets zijn gebruikt hij 0
            {
                latest_Ticket = new Incident_Ticket();
                latest_Ticket.id = 0;
            }
        }
        private void BTN_add_Click(object sender, EventArgs e)// voegt ticket toe
        {
            if (DTP_ReportDate.Text != "" && TXB_Subject.Text != "" && CB_incidentType.Text != "" && CB_ReportedBy.Text != "" && CB_Priority.Text != "" && DTP_Deadline.Text != "" && RTB_Description.Text != "")
            {
                try
                {
                    Incident_Ticket t = new Incident_Ticket();
                    //tijdelijkt
                    t.id = latest_Ticket.id + 1;
                    t.reportDate = DateTime.Parse(DTP_ReportDate.Text);
                    t.subjectOfIncident = TXB_Subject.Text;
                    t.Incident_Type = (Incident_Type)Enum.Parse(typeof(Incident_Type), CB_incidentType.Text, true);
                    t.ReportedBy = CB_ReportedBy.Text;
                    t.Incident_Priority = (Incident_Priority)Enum.Parse(typeof(Incident_Priority), CB_Priority.Text, true);
                    t.Deadline = DateTime.Parse(DTP_Deadline.Text);
                    t.Description = RTB_Description.Text;
                    t.Status = Incident_Status.Open;
                    incident_TickedLogic.AddTicket(t);

                    MessageBox.Show("Ticket has been added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);// laat de gebruiker weten dat het is gelukt
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Was not able to add ticket. Try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// laat de gebruiker weten dat het is gelukt
                    LBL_Error.Text = "An unexpecter error has occurred";
                }

            }
            else
            {
                LBL_Error.Text = "Fill in all fields";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)// dit is het zwarte randje langs de rich textbox want die heeft geen border
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        public void ComboBoxSetting()// vult de comboboxes
        {
            foreach (var item in Incident_Type.GetValues(typeof(Incident_Type)))
            {
                CB_incidentType.Items.Add(item);
            }

            foreach (var item in Incident_Priority.GetValues(typeof(Incident_Priority)))
            {
                CB_Priority.Items.Add(item);
            }

            List<User> users = user_Logic.GetAllUsers();
            foreach (User user in users)
            {
                CB_ReportedBy.Items.Add(user.emailAddress);
            }
        }

        private void BTN_cancel_Click(object sender, EventArgs e)// sluit het form
        {
            this.Close();
        }

        private void Btn_logOut_Click(object sender, EventArgs e)// logt uit
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }
    }
}
