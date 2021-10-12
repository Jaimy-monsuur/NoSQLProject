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
        private string CollectionName()// returnt de naam van de collection
        {
            return "Incident_Ticket";
        }

        public List<Incident_Ticket> GetAllTickets()
        {
            return ToInsident_Ticket(GetCollection(CollectionName()));//haalt alle tickets op
        }

        public List<Incident_Ticket> GetMaxId()
        {
            return ToInsident_Ticket(GetMax(CollectionName(), "Incident_Id"));//haalt alle tickets op
        }

        public void InsertTicket(Incident_Ticket t)// insert een ticket
        {
            BsonDocument document = new BsonDocument()
            { //object id word aan gemaakt in de db zelf
                { "Incident_Id", t.id },
                { "Date", t.reportDate },
                { "Subject", t.subjectOfIncident },
                { "Type", t.Incident_Type },
                { "Reported_By", t.ReportedBy },
                { "Priority", t.Incident_Priority },
                { "Deadline", t.Deadline },
                { "Description", t.Description },
                { "Status", t.Status },
            };
            Insert(CollectionName(), document);
        }

        private List<Incident_Ticket> ToInsident_Ticket(List<BsonDocument> T)// zet List<BsonDocument> lijst om naar  List<Incident_Ticket>
        {
            List<Incident_Ticket> list = new List<Incident_Ticket>();
            foreach (BsonDocument item in T)
            {
                Incident_Ticket ticket = new Incident_Ticket()
                {
                    objectId = (ObjectId)item["_id"],
                    id = (int)item["Incident_Id"],
                    reportDate = (DateTime)item["Date"],
                    subjectOfIncident = (string)item["Subject"],
                    Incident_Type = (string)item["Type"],
                    ReportedBy = (string)item["Reported_By"],//later aan passen naar class user
                    Incident_Priority = (string)item["Priority"],
                    Deadline = (DateTime)item["Deadline"],
                    Description = (string)item["Description"],
                    Status = (string)item["Status"]
                };
                list.Add(ticket);
            }
            return list;
        }

    }
}