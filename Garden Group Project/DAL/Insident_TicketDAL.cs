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
    public class Insident_TicketDAL : Base
    {
        public Insident_TicketDAL() : base()
        {
            collection = db.GetCollection<BsonDocument>("grades");
        }
        
        public void GetById()
        {

        }
    }
}