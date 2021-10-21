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

        protected List<BsonDocument> GetMax(string colName, string fieldName)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            var f = Builders<BsonDocument>.Sort.Descending(fieldName);
            return collection.Find(new BsonDocument()).Sort(f).ToList();
        }

        protected List<BsonDocument> GetCollectionFiltered(string colName,string field, string value)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            var f = Builders<BsonDocument>.Filter.Eq(field, value);
            return collection.Find(f).ToList();
        }

        protected void Insert(string colName, BsonDocument doc)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            collection.InsertOne(doc);
        }

        protected void UpdateOne(string colName, string filterField, ObjectId filtervalue, string updateField, string updateValue)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);

            var f = Builders<BsonDocument>.Filter.Eq(filterField, filtervalue);
            var u = Builders<BsonDocument>.Update.Set(updateField, updateValue);
            collection.UpdateOne(f, u);
        }
        protected void UpdateOne(string colName, string filterField, string filtervalue, string updateField, string updateValue)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);

            var f = Builders<BsonDocument>.Filter.Eq(filterField, filtervalue);
            var u = Builders<BsonDocument>.Update.Set(updateField, updateValue);
            collection.UpdateOne(f, u);
        }

        protected void Delete(string colName, string fieldname, ObjectId id)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            var deleteFilter = Builders<BsonDocument>.Filter.Eq(fieldname, id);
            collection.DeleteOne(deleteFilter);
        }
    }
}
