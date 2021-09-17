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
        protected string connectionString;
        protected MongoClient dbClient;
        protected IMongoDatabase db;
        protected Base()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            dbClient = new MongoClient(connectionString);
            db = dbClient.GetDatabase("Garden_Goup");
        }

        public List<BsonDocument> GetCollecction(string colName)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            return collection.Find(new BsonDocument()).ToList();
        }
    }
}
