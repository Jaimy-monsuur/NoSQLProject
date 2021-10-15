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
    public partial class Update_Ticket : Form
    {
        Incident_Ticket selectedTicket;
        User_Logic logic = new User_Logic();

        public Update_Ticket(Incident_Ticket ticket)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            selectedTicket = ticket;
        }

        public void DataGridViewSetings()
        {
            DGV_Selected.ColumnCount = 2;
            DGV_Selected.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGV_Selected.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DGV_Selected.Columns[0].Name = "Selected Ticket";
            DGV_Selected.Columns[1].Name = "";
            DGV_Selected.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            DGV_Selected.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            DGV_Selected.Rows.Clear();
            DGV_Selected.Rows.Add("ID: ", selectedTicket.id);
            DGV_Selected.Rows.Add("Reported By: ", selectedTicket.ReportedBy);
            DGV_Selected.Rows.Add("Subject: ", selectedTicket.subjectOfIncident);
            DGV_Selected.Rows.Add("Description: ", selectedTicket.Description);
            DGV_Selected.Rows.Add("Type: ", selectedTicket.Incident_Type);
            DGV_Selected.Rows.Add("Priority: ", selectedTicket.Incident_Priority);
            DGV_Selected.Rows.Add("Status: ", selectedTicket.Status);
            DGV_Selected.Rows.Add("Report date: ", selectedTicket.reportDate.ToShortDateString());
            DGV_Selected.Rows.Add("Deadline: ", selectedTicket.Deadline.ToShortDateString());
        }

        private void Create_Ticket_Load(object sender, EventArgs e)
        {
            DataGridViewSetings();
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
