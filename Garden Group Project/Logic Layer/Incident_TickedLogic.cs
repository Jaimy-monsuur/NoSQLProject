using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace Logic_Layer
{
    public class Incident_TickedLogic
    {
        Incident_TicketDAL dal = new Incident_TicketDAL();
        public List<Incident_Ticket> GetAllTickets()
        {
            return dal.GetAllTickets();
        }
        public List<Incident_Ticket> GetAllTicketsFiltered(string fieldname, string value)
        {
            return dal.GetAllTicketsFiltered(fieldname, value);
        }
        public List<Incident_Ticket> GetOpenTickets()
        {
            return dal.GetAllTicketsWithStatusOpen();
        }
        public List<Incident_Ticket> GetDeadlineTickets()
        {
            return dal.GetAllTicketsWithDeadline();
        }
        public List<Incident_Ticket> GetMaxId()
        {
            return dal.GetMaxId();
        }

        public void AddTicket(Incident_Ticket ticket)
        {
            dal.InsertTicket(ticket);
        }
        
        public void DeleteTicket(Incident_Ticket ticket)
        {
            dal.DelTicket(ticket);
        }
        public void Update(Incident_Ticket t, string updateField, string updateValue)
        {
            dal.UpdateTicket(t, updateField, updateValue);
        }
    }
}
