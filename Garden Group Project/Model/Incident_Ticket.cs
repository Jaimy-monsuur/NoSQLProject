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
        public Incident_Type Incident_Type;
        public string ReportedBy;
        public Incident_Priority Incident_Priority;
        public DateTime Deadline;
        public string Description;
        public Incident_Status Status;
    }
}
