using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace Logic_Layer
{
    public class User_Logic
    {
        UserDAL userDAL = new UserDAL();

        public List<User> GetAllUsers()
        {
            return userDAL.GetAllUsers();
        }

        public List<User> GetMaxId()
        {
            return userDAL.GetMaxId();
        }

        public void AddUser(User user)
        {
            userDAL.InsertUser(user);
        }
    }
}
