using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace DAL
{
    class Insident_TicketDAL : Base
    {
        private IMongoCollection<BsonDocument> collection;
        public Insident_TicketDAL() : base()
        {
            collection = db.GetCollection<BsonDocument>("grades");
        }
        
        public void GetById()
        {
            string q = "{ Incident_Id :1 }";

            List<BsonDocument> documents = Find(collection, q);
            Console.WriteLine(documents);
        }
    }
}