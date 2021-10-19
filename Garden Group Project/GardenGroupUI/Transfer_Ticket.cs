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
    public partial class Transfer_Ticket : Form
    {
        Incident_Ticket selectedTicket;
        User_Logic userLogic = new User_Logic();
        Incident_TickedLogic incidentLogic = new Incident_TickedLogic();

        public Transfer_Ticket(Incident_Ticket ticket)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            selectedTicket = ticket;
            SetListview();
            LBL_Selected.Text = selectedTicket.ReportedBy;
        }

        private void SetListview()
        {
            DGV_SelectedTicket.Rows.Clear();
            DGV_SelectedTicket.Rows.Add("ID: ", selectedTicket.id);
            DGV_SelectedTicket.Rows.Add("Subject: ", selectedTicket.subjectOfIncident);
            DGV_SelectedTicket.Rows.Add("Priority: ", selectedTicket.Incident_Priority);
            DGV_SelectedTicket.Rows.Add("Status: ", selectedTicket.Status);
            DGV_SelectedTicket.Rows.Add("Report date: ", selectedTicket.reportDate.ToShortDateString());
            DGV_SelectedTicket.Rows.Add("Deadline: ", selectedTicket.Deadline.ToShortDateString());
        }

        private void Create_Ticket_Load(object sender, EventArgs e)
        {
            ComboBoxSetting();
        }

        public void ComboBoxSetting()
        {
            List<User> users = userLogic.GetAllUsers();
            foreach (User user in users)
            {
                if (user.emailAddress != selectedTicket.ReportedBy)
                {
                    CB_TransferTo.Items.Add(user.emailAddress);
                }            
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

        private void BTN_Transfer_Click(object sender, EventArgs e)
        {
            if (CB_TransferTo.Text != "")
            {
                selectedTicket.ReportedBy = CB_TransferTo.Text;
                MessageBox.Show("Ticket succesfully transfered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string updateField = "Reported_By";
                string updateValue = $"{selectedTicket.ReportedBy}";
                incidentLogic.Update(selectedTicket, updateField, updateValue);
                this.Close();
            }
            else
            {
                MessageBox.Show("No user selected, select a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
    }
}
