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
            return BsonToUser(GetCollection(CollectionName())); // haalt alle bson op en zet ze om in users 
        }

        public void InsertUser(User user)
        {

            byte[] encodedPasswordArray = new byte[user.password.Length]; // encrypt het password
            encodedPasswordArray = Encoding.UTF8.GetBytes(user.password);
            BsonDocument document = new BsonDocument()
            {
                { "User_Id", user.userId }, // object id wordt in db aangemaakt
                { "First_Name", user.firstName },
                { "Last_Name", user.lastName },
                { "User_Type", user.userType.ToString() },
                { "Email_Address", user.emailAddress },
                { "Phone_Number", user.phoneNumber },
                { "Location", user.location },
                { "Password", encodedPasswordArray.ToString() } // moet nog getest worden op werking
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
                    userType = (User_Type)Enum.Parse(typeof(User_Type), (string)bson["User_Type"], true),
                    emailAddress = (string)bson["Email_Address"],
                    phoneNumber = (string)bson["Phone_Number"],
                    location = (string)bson["Location"],
                    password = (string)bson["Password"]
                };
                users.Add(user);
            }

            return users;
        }

        public List<User> GetMaxId()
        {
            return BsonToUser(GetMax(CollectionName(), "User_Id")); // haalt alle users op om te kijken wat de hoogste user id is
        }

        public List<User> GetUser(string email)
        {
            return BsonToUser(GetCollectionFiltered(CollectionName(), "Email_Address", email));//haalt users op een filter
        }
    }
}
