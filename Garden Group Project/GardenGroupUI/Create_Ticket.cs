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
        Incident_TickedLogic incident_TickedLogic = new Incident_TickedLogic();
        User_Logic user_Logic = new User_Logic();

        public Create_Ticket()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Create_Ticket_Load(object sender, EventArgs e)
        {
            latest_Ticket = incident_TickedLogic.GetMaxId()[0];
            DTP_Deadline.MinDate = DateTime.Now;// deadline can not be in the past when creating a new ticket
            DTP_ReportDate.MinDate = DateTime.Now.AddDays(-7); // The report date can be a bit in the past but not in the future
            DTP_ReportDate.MaxDate = DateTime.Now;
            ComboBoxSetting();
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            if (DTP_ReportDate.Text != "" && TXB_Subject.Text != "" && CB_incidentType.Text != "" && CB_ReportedBy.Text != "" && CB_Priority.Text != "" && DTP_Deadline.Text != "" && RTB_Description.Text != "")
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
                try
                {
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        public void ComboBoxSetting()
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

        private void BTN_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_logOut_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }
    }
}
