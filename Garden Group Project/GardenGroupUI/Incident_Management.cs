using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logic_Layer;
using Model;

namespace GardenGroupUI
{
    public partial class Incident_Management : Form
    {
        public Incident_TickedLogic logic_Layer = new Incident_TickedLogic();

        public Incident_Management()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }


        private void Incident_Management_Load(object sender, EventArgs e)
        {
            //for the default text in textbox
            this.TBXfilter.Enter += new EventHandler(TBXfilter_Enter);
            this.TBXfilter.Leave += new EventHandler(TBXfilter_Leave);
            TBXfilter_SetText();
            SetListvieuw();
            GetLVData();
            DataGridViewSetings();
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
        }

        protected void SetListvieuw()
        {
            LVTickets.Clear();
            // Maak grid
            LVTickets.Clear();
            LVTickets.View = View.Details;
            LVTickets.GridLines = true;
            LVTickets.FullRowSelect = true;

            // Voeg column header toe
            LVTickets.Columns.Add("Id:", 50);
            LVTickets.Columns.Add("User:", 260);
            LVTickets.Columns.Add("Subject:", 100);
            LVTickets.Columns.Add("Report date:", 110);
            LVTickets.Columns.Add("Deadline:", 100);
            LVTickets.Columns.Add("Priority:", 70);
            LVTickets.Columns.Add("Status:", 70);
        }
        protected void GetLVData()
        {
            List<Incident_Ticket> list = logic_Layer.GetAllTickets();
            foreach (Incident_Ticket item in list)
            {
                string[] collumnItems = new string[7];
                collumnItems[0] = item.id.ToString();
                collumnItems[1] = item.ReportedBy;
                collumnItems[2] = item.subjectOfIncident;
                collumnItems[3] = item.reportDate.ToShortDateString();
                collumnItems[4] = item.Deadline.ToShortDateString();
                collumnItems[5] = item.Incident_Priority.ToString();
                collumnItems[6] = item.Status.ToString();
                ListViewItem li = new ListViewItem(collumnItems);
                li.Tag = item;// zodat je het object terug kan vinden
                LVTickets.Items.Add(li);
            }
        }

        //for the defoult text in a text box
        protected void TBXfilter_SetText()
        {
            this.TBXfilter.Text = "Filter by subject";
            TBXfilter.ForeColor = Color.Gray;
        }

        private void TBXfilter_Enter(object sender, EventArgs e)// haalt de default text weg als je gaat typen
        {
            if (TBXfilter.ForeColor == Color.Black)
                return;
            TBXfilter.Text = "";
            TBXfilter.ForeColor = Color.Black;
        }
        private void TBXfilter_Leave(object sender, EventArgs e)// plaatst de default text terug als je het leeg laat
        {
            if (TBXfilter.Text.Trim() == "")
                TBXfilter_SetText();
        }

        private void BTNaddTicket_Click(object sender, EventArgs e)
        {
            Create_Ticket create_Ticket = new Create_Ticket();
            create_Ticket.ShowDialog();
            SetListvieuw();// haalt nieuwe gegevens op
            GetLVData();
        }


        private void LVTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVTickets.SelectedItems.Count != 0)
            {
                ListViewItem li = (ListViewItem)LVTickets.SelectedItems[0];
                Incident_Ticket t = (Incident_Ticket)li.Tag;

                DGV_Selected.Rows.Clear();
                DGV_Selected.Rows.Add("ID: ", t.id);
                DGV_Selected.Rows.Add("Reported By: ", t.ReportedBy);
                DGV_Selected.Rows.Add("Subject: ", t.subjectOfIncident);
                DGV_Selected.Rows.Add("Description: ", t.Description);
                DGV_Selected.Rows.Add("Type: ", t.Incident_Type);
                DGV_Selected.Rows.Add("Priority: ", t.Incident_Priority);
                DGV_Selected.Rows.Add("Status: ", t.Status);
                DGV_Selected.Rows.Add("Report date: ", t.reportDate.ToShortDateString());
                DGV_Selected.Rows.Add("Deadline: ", t.Deadline.ToShortDateString());
            }
        }

        private void Btn_logOut_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }
    }
}
