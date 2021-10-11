using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace Model
{
    public class Incident_Ticket
    {
        public ObjectId objectId;
        public int id;
        public DateTime reportDate;
        public string subjectOfIncident;
        public string Incident_Type;
        public string ReportedBy;
        public string Incident_Priority;
        public DateTime Deadline;
        public string Description;
        public string Status;
    }
}
