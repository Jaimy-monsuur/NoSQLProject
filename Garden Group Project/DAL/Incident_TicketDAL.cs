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
    public class Incident_TicketDAL : Base
    {
        private string CollectionName()
        {
            return "Incident_Ticket";
        }

        public List<Incident_Ticket> GetAllTickets()
        {

            return ToInsident_Ticket(GetCollecction(CollectionName()));
            // nog een return
        }

        private List<Incident_Ticket> ToInsident_Ticket(List<BsonDocument> T)
        {
            List<Incident_Ticket> list = new List<Incident_Ticket>();
            foreach (BsonDocument item in T)
            {
                Incident_Ticket ticket = new Incident_Ticket()
                {
                    //objectId = (int)item["_id"],
                    id = (int)item["Incident_Id"],
                    Description = (string)item["Description"]

                };
                list.Add(ticket);
            }
            return list;
        }

    }
}