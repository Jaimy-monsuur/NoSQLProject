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

        public List<BsonDocument> Find(IMongoCollection<BsonDocument> collection, string query)
        {
            try
            {
                //ophalen uit db
                List<BsonDocument> documents = (List<BsonDocument>)collection.Find(query);

                return documents;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
