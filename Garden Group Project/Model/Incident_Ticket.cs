using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Incident_Ticket
    {
        public int objectId;
        public int id;
        public DateTime reportDate;
        public string subjectOfIncident;
        public Incident_Type Incident_Type;
        public string ReportedBy;
        public Incident_Priority Incident_Priority;
        public DateTime Deadline;
        public string Description;
    }
}
