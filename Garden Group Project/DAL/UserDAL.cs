using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Model;

namespace DAL
{
    public class UserDAL : Base
    {
        private string CollectionName()
        {
            return "Users";
        }

        public List<User> GetAllUsers()
        {
            return null; // zorg dat alle users opgehaald worden WERKT NIET
        }

        public void InsertUser(User user)
        {
            BsonDocument document = new BsonDocument()
            {
                { "User_Id", user.userId }, // object id wordt in db aangemaakt
                { "First_Name", user.firstName },
                { "Last_Name", user.lastName },
                { "User_Type", user.userType.ToString() },
                { "Email_Address", user.emailAddress },
                { "Phone_Number", user.phoneNumber },
                { "Location", user.location.ToString() },
                { "Password", user.password }
            };
            Insert(CollectionName(), document);
        }

        private List<User> BsonToUser(List<BsonDocument> bsonDocuments)
        {
            List<User> users = new List<User>();

            foreach (BsonDocument bson in bsonDocuments)
            {
                User user = new User()
                {
                    objectId = (ObjectId)bson["_id"],
                    userId = (int)bson["User_Id"],
                    firstName = (string)bson["First_Name"],
                    lastName = (string)bson["Last_Name"],
                    password = (string)bson["Password"],
                    userType = (User_Type)bson["User_Type"], // WERKT NIET
                    emailAddress = (string)bson["Email_Address"],
                    phoneNumber = (string)bson["Phone_Number"],
                    location = (Location)bson["Location"] // WERKT NIET
                };
                users.Add(user);
            }

            return users;
        }
    }
}
