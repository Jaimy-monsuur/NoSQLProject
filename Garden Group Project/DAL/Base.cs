using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace DAL
{
    public abstract class Base
    {
        public string connectionString;
        public MongoClient dbClient;
        public IMongoDatabase db;
        public Base()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            dbClient = new MongoClient(connectionString);
            db = dbClient.GetDatabase("Garden_Goup");
        }
    }
}
