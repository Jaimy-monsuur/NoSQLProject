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
            LVUsers.Clear();
            LVUsers.View = View.Details;
            LVUsers.GridLines = true;
            LVUsers.FullRowSelect = true;

            // Voeg column header toe
            LVUsers.Columns.Add("Id:", 100);
            LVUsers.Columns.Add("User id:", 50);
            LVUsers.Columns.Add("First name:", 100);
            LVUsers.Columns.Add("Last name:", 100);
            LVUsers.Columns.Add("User type:", 100);
            LVUsers.Columns.Add("Email-address:", 100);
            LVUsers.Columns.Add("Phone number:", 100);
            LVUsers.Columns.Add("Location:", 100);
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
                LVUsers.Items.Add(li);
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
            SetListview();
            GetLVData();
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
            SetListview();
            GetLVData();
        }

        private void Btn_logOut_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }
    }
}
