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
        
        public User GetUser(string userName)
        {
            User user = new User();
            byte[] encodedPasswordArray = new byte["admin".Length];
            encodedPasswordArray = System.Text.Encoding.UTF8.GetBytes("admin");
            string password = Convert.ToBase64String(encodedPasswordArray);
            user.password = password;
            user.userType = (User_Type)0;
            return user;
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
