﻿using System;
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
        Incident_TickedLogic incident_TickedLogic = new Incident_TickedLogic();

        public Update_Ticket(Incident_Ticket ticket)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            selectedTicket = ticket;
        }

        private void Create_Ticket_Load(object sender, EventArgs e)
        {
            DataGridViewSetings();
            ComboBoxSetting();
            if (selectedTicket.Status == Incident_Status.Closed)
            {
                GB_Close.Text = "Open ticket";
                LB_close.Text = "Ticket status will be changed to: Open";
                BTN_Close.Text = "Open Ticket";
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

        private void BTN_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_logOut_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }
        public void ComboBoxSetting()
        {
            foreach (Incident_Priority item in Incident_Priority.GetValues(typeof(Incident_Priority)))
            {
                if (item != selectedTicket.Incident_Priority)
                {
                    CB_Priority.Items.Add(item);
                }
            }
        }

        private void BTN_Escalate_Click(object sender, EventArgs e)
        {
            if (CB_Priority.Text != "")
            {
                try
                {
                    selectedTicket.Incident_Priority = (Incident_Priority)Enum.Parse(typeof(Incident_Priority), CB_Priority.Text, true);
                    string updateField = "Priority";
                    string updateValue = $"{selectedTicket.Incident_Priority}";
                    incident_TickedLogic.Update(selectedTicket, updateField, updateValue);
                    MessageBox.Show("Ticket has been updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);// laat de gebruiker weten dat het is gelukt
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Was not able to update ticket. Try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// laat de gebruiker weten dat het niet is gelukt
                }
            }
            else
            {
                MessageBox.Show("Select a new Priority", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);// laat de gebruiker weten dat het is mislukt
            }
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            string Message;
            if (selectedTicket.Status == Incident_Status.Closed)
            {
                Message = "Are u sure that u want to Open this Ticket";
            }
            else
            {
                Message = "Are u sure that u want to Close this Ticket";
            }
            DialogResult dialogResult = MessageBox.Show(Message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);// laat de gebruiker weten dat het is mislukt
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (selectedTicket.Status == Incident_Status.Closed)
                    {
                        selectedTicket.Status = Incident_Status.Open;
                    }
                    else
                    {
                        selectedTicket.Status = Incident_Status.Closed;
                    }
                    string updateField = "Status";
                    string updateValue = $"{selectedTicket.Status}";
                    incident_TickedLogic.Update(selectedTicket, updateField, updateValue);
                    MessageBox.Show("Ticket has been updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);// laat de gebruiker weten dat het is gelukt
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Was not able to update ticket. Try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// laat de gebruiker weten dat het niet is gelukt
                }
            }
        }
    }
}