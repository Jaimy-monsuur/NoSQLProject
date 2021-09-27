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

        protected List<BsonDocument> GetCollection(string colName)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            return collection.Find(new BsonDocument()).ToList();
        }

        protected List<BsonDocument> GetCollectionFiltered(string colName,string filter)// filter must be like this: string filter = "\"id\", 1000"
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            string[] filterArray = filter.Split(",");
            var f = Builders<BsonDocument>.Filter.Eq(filterArray[0], filterArray[1]);// mischien nog aan passen???
            return collection.Find(new BsonDocument()).ToList();//WERKT NOG NIET!!!!!
        }

        protected void Insert(string colName, BsonDocument doc)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            collection.InsertOne(doc);
        }

        protected void UpdateOne(string colName, string filter, string updateTo)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);// filter and update must be like this: string filter = "\"id\", 1000"
            string[] filterArray = filter.Split(",");
            string[] updateArray = filter.Split(",");
            var f = Builders<BsonDocument>.Filter.Eq(filterArray[0], filterArray[1]);// mischien nog aan passen???
            var u = Builders<BsonDocument>.Update.Set(updateArray[0], updateArray[1]);// mischien nog aan passen???
            collection.UpdateOne(f, u);
        }

        protected void UpdateMany(string colName, string filter, string updateTo)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);// filter and update must be like this: string filter = "\"id\", 1000"
            string[] filterArray = filter.Split(",");
            string[] updateArray = filter.Split(",");
            var f = Builders<BsonDocument>.Filter.Eq(filterArray[0], filterArray[1]);// mischien nog aan passen???
            var u = Builders<BsonDocument>.Update.Set(updateArray[0], updateArray[1]);// mischien nog aan passen???
            collection.UpdateMany(f, u);
        }

        protected void Delete(string colName, string filter)// filter must be like this: string filter = "\"id\", 1000"
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            string[] filterArray = filter.Split(",");
            var deleteFilter = Builders<BsonDocument>.Filter.Eq(filterArray[0], filterArray[1]);// mischien nog aan passen???
            collection.DeleteOne(deleteFilter);
        }
    }
}
