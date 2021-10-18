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
        User_Logic logic = new User_Logic();

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
            LV_SelectedTicket.Clear();
            // Maak grid
            LV_SelectedTicket.Clear();
            LV_SelectedTicket.View = View.Details;
            LV_SelectedTicket.GridLines = true;
            LV_SelectedTicket.FullRowSelect = true;

            // Voeg column header toe
            LV_SelectedTicket.Columns.Add("Id:", 50);
            LV_SelectedTicket.Columns.Add("Subject:", 100);
            LV_SelectedTicket.Columns.Add("Report date:", 110);
            LV_SelectedTicket.Columns.Add("Deadline:", 100);
            LV_SelectedTicket.Columns.Add("Priority:", 70);
            LV_SelectedTicket.Columns.Add("Status:", 70);

            string[] collumnItems = new string[6];
            collumnItems[0] = selectedTicket.id.ToString();
            collumnItems[1] = selectedTicket.subjectOfIncident;
            collumnItems[2] = selectedTicket.reportDate.ToShortDateString();
            collumnItems[3] = selectedTicket.Deadline.ToShortDateString();
            collumnItems[4] = selectedTicket.Incident_Priority.ToString();
            collumnItems[5] = selectedTicket.Status.ToString();
            ListViewItem li = new ListViewItem(collumnItems);
            LV_SelectedTicket.Items.Add(li);
        }

        private void Create_Ticket_Load(object sender, EventArgs e)
        {
            ComboBoxSetting();
        }

        public void ComboBoxSetting()
        {
            List<User> users = logic.GetAllUsers();
            foreach (User user in users)
            {
                CB_TransferTo.Items.Add(user.emailAddress);
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
