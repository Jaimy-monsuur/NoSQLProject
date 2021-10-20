﻿using System;
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
    public partial class User_Management : Form
    {
        User_Logic userLogic = new User_Logic();

        public User_Management()
        {
            InitializeComponent();
        }

        private void PNLmain_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, PNLmain.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void menuStripUser_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Menu.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        protected void SetListview()
        {
            // Maak grid
            LVTickets.Clear();
            LVTickets.View = View.Details;
            LVTickets.GridLines = true;
            LVTickets.FullRowSelect = true;

            // Voeg column header toe
            LVTickets.Columns.Add("Id:", 100);
            LVTickets.Columns.Add("User id:", 50);
            LVTickets.Columns.Add("First name:", 100);
            LVTickets.Columns.Add("Last name:", 100);
            LVTickets.Columns.Add("User type:", 100);
            LVTickets.Columns.Add("Email-address:", 100);
            LVTickets.Columns.Add("Phone number:", 100);
            LVTickets.Columns.Add("Location:", 100);
        }

        protected void GetLVData()
        {
            List<User> list = userLogic.GetAllUsers();
            foreach (User user in list)
            {
                string[] collumnItems = new string[8];
                collumnItems[0] = user.objectId.ToString();
                collumnItems[1] = user.userId.ToString();
                collumnItems[2] = user.firstName;
                collumnItems[3] = user.lastName;
                collumnItems[4] = user.userType.ToString();
                collumnItems[5] = user.emailAddress;
                collumnItems[6] = user.phoneNumber;
                collumnItems[7] = user.location;
                ListViewItem li = new ListViewItem(collumnItems);
                li.Tag = user; // je kan het object terug kan vinden
                LVTickets.Items.Add(li);
            }
        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            // sets size of menu
            foreach (ToolStripItem item in Menu.Items)
            {
                item.Size = new Size(415, 24);
            }
            SetListview();
            GetLVData();
        }

        private void BTNAddUser_Click_1(object sender, EventArgs e)
        {
            Create_User createUser = new Create_User();
            this.Hide();
            createUser.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show(); // show of show dialog?????
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Incident_Management incident_Management = new Incident_Management();
            incident_Management.Show(); // show of show dialog?????
            this.Close();
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            GetLVData();
        }
    }
}
