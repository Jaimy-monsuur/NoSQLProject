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
    public partial class Create_User : Form
    {
        User latestUser;
        User_Logic logic = new User_Logic();

        public Create_User()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Create_User_Load(object sender, EventArgs e)
        {
            latestUser = logic.GetMaxId()[0];
            ComboBoxSetting();
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXB_FirstName.Text != "" && TXB_LastName.Text != "" && CB_UserType.Text != "" && TXB_EmailAdress.Text != "" && TXB_PhoneNumber.Text!= "" && TXB_Location.Text != "" && TXB_Password.Text != "" )
                {
                    User u = new User();
                    // ZORG DAT ER GEEN ANDERE LETTERS EN CIJFERS WAAR NIET MOET KAN
                    u.userId = latestUser.userId + 1;
                    u.firstName = TXB_FirstName.Text;
                    u.lastName = TXB_LastName.Text;
                    u.userType = (User_Type)Enum.Parse(typeof(User_Type), CB_UserType.Text, true);
                    u.emailAddress = TXB_EmailAdress.Text;
                    u.phoneNumber = TXB_PhoneNumber.Text;
                    u.location = TXB_Location.Text;
                    u.password = TXB_Password.Text; // moet nog encrypted worden

                    logic.AddUser(u);
                    this.Close();
                }
                else
                {
                    LBL_Error.Text = "Fill in all fields";
                }
            }
            catch (Exception)
            {
                LBL_Error.Text = "An unexpected error has occurred";
            }
        }

        public void ComboBoxSetting()
        {
            foreach (var item in User_Type.GetValues(typeof(User_Type)))
            {
                CB_UserType.Items.Add(item);
            }
        }

        private void Btn_logOut_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
