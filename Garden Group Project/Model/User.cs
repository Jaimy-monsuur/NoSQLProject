using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace Model
{
    public class User
    {
        public ObjectId objectId;
        public int userId;
        public string firstName;
        public string lastName;
        public string password;
        public User_Type userType;
        public string emailAddress;
        public string phoneNumber;
        public Location location;
    }
}
