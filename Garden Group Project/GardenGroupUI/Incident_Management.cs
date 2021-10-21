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
            checkBox1.Appearance = Appearance.Button;
        }


        private void Incident_Management_Load(object sender, EventArgs e)
        {
            UserSettings();
            SetListvieuw();
            GetLVData();
            DataGridViewSetings();
        }

        public void UserSettings()
        {
            if (Program.loggedInUser.userType == User_Type.Employee)
            {
                BTN_RemoveTicket.Hide();
                BTN_TransferTicket.Hide();
                userManagementToolStripMenuItem.Enabled = false;
            }
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
            List<Incident_Ticket> list;
            if (checkBox1.Checked)
            {
                list = logic_Layer.GetAllTicketsFiltered("Status", "Closed");
            }
            else
            {
                 list = logic_Layer.GetAllTicketsFiltered("Status", "Open");
            }

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
        //**
        //Extra funcionality Jelle
        //**
        protected void SortedinListview(List<Incident_Ticket> PrioLow)
        {
            foreach (Incident_Ticket item in PrioLow)
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
        protected void SortOnPriority()
        {
            List<Incident_Ticket> list;
            List<Incident_Ticket> PrioLow = new List<Incident_Ticket>();
            List<Incident_Ticket> PrioMed = new List<Incident_Ticket>();
            List<Incident_Ticket> PrioHig = new List<Incident_Ticket>();
            if (checkBox1.Checked)
            {
                list = logic_Layer.GetAllTicketsFiltered("Status", "Closed");
            }
            else
            {
                list = logic_Layer.GetAllTicketsFiltered("Status", "Open");
            }

            foreach (Incident_Ticket item in list)
            {
                switch (item.Incident_Priority)
                {
                    case Incident_Priority.Low:
                        PrioLow.Add(item);
                        break;
                    case Incident_Priority.Medium:
                        PrioMed.Add(item);
                        break;
                    case Incident_Priority.High:
                        PrioHig.Add(item);
                        break;
                }
            }
            if (Rbtn_HightToLow.Checked == true)
            {
                SortedinListview(PrioHig);
                SortedinListview(PrioMed);
                SortedinListview(PrioLow);
            }
            else if (Rbtn_LowToHigh.Checked == true)
            {
                SortedinListview(PrioLow);
                SortedinListview(PrioMed);
                SortedinListview(PrioHig);
            }
        }
        //**
        //End Extra funcionality Jelle
        //*
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

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Management man = new User_Management();
            man.ShowDialog();
            this.Close();
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            if (LVTickets.SelectedItems.Count != 0)
            {
                if (Program.loggedInUser.userType == User_Type.Employee)
                {
                    ListViewItem li = (ListViewItem)LVTickets.SelectedItems[0];
                    Incident_Ticket t = (Incident_Ticket)li.Tag;
                    if (t.ReportedBy == Program.loggedInUser.emailAddress)
                    {
                        TryUpdate();
                    }
                    else
                    {
                        MessageBox.Show("U can not update this ticket because it is not yours", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);// laat de gebruiker weten dat het is mislukt
                    }
                }
                else
                {
                    TryUpdate();
                }
            }
            else
            {
                NoTicketSelected();
            }
        }
        public void TryUpdate()
        {
            try
            {
                ListViewItem li = (ListViewItem)LVTickets.SelectedItems[0];
                Incident_Ticket t = (Incident_Ticket)li.Tag;
                Update_Ticket update_Ticket = new Update_Ticket(t);
                update_Ticket.ShowDialog();
                SetListvieuw(); // haalt nieuwe gegevens op
                GetLVData();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// laat de gebruiker weten dat het niet is gelukt
            }
        }

        private void BTN_TransferTicket_Click(object sender, EventArgs e)
        {
            if (LVTickets.SelectedItems.Count != 0)
            {
                try
                {
                    ListViewItem li = (ListViewItem)LVTickets.SelectedItems[0];
                    Incident_Ticket t = (Incident_Ticket)li.Tag;
                    Transfer_Ticket transfer = new Transfer_Ticket(t);
                    transfer.ShowDialog();
                    SetListvieuw(); // haalt nieuwe gegevens op
                    GetLVData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong. Try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// laat de gebruiker weten dat het niet is gelukt
                }
            }
            else
            {
                NoTicketSelected();
            }
        }

        public void NoTicketSelected()
        {
            MessageBox.Show("No ticket selected, select a ticket", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);// laat de gebruiker weten dat het is mislukt
        }

        private void BTN_RemoveTicket_Click(object sender, EventArgs e)
        {
            if (LVTickets.SelectedItems.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are u sure that u want to delete this user", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);// laat de gebruiker weten dat het is mislukt
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        ListViewItem li = (ListViewItem)LVTickets.SelectedItems[0];
                        Incident_Ticket t = (Incident_Ticket)li.Tag;
                        logic_Layer.DeleteTicket(t);
                        SetListvieuw();// haalt nieuwe gegevens op
                        GetLVData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Was not able to delete ticket. Try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// laat de gebruiker weten dat het niet is gelukt
                    }
                }
            }
            else
            {
                NoTicketSelected();
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Show Status open";
                SetListvieuw();// haalt nieuwe gegevens op
                GetLVData();
                LBL_status.Text = "Closed tickets";
            }
            else
            {
                checkBox1.Text = "Show Status closed";
                SetListvieuw();// haalt nieuwe gegevens op
                GetLVData();
                LBL_status.Text = "Open tickets";
            }
        }

        private void BTNupdate_Click(object sender, EventArgs e)
        {
            SetListvieuw();// haalt nieuwe gegevens op
            GetLVData();
        }

        private void Btn_Sort_Click(object sender, EventArgs e)
        {

        }

        private void Rbtn_HightToLow_CheckedChanged(object sender, EventArgs e)
        {
            SetListvieuw();
            SortOnPriority();
        }

        private void Rbtn_LowToHigh_CheckedChanged(object sender, EventArgs e)
        {
            SetListvieuw();
            SortOnPriority();
        }
    }
}
