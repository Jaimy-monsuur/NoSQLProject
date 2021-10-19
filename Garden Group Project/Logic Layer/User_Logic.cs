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
        
        public List<User> GetUser(string email)
        {
            return userDAL.GetUser(email);
        }

        public void UpdatePassword(string email, string newPassword)
        {
            userDAL.UpdatePassword(email, newPassword);
        }

        public void AddUser(User user)
        {
            userDAL.InsertUser(user);
        }

        public List<User> GetMaxId()
        {
            return userDAL.GetMaxId();
        }

    }
}
