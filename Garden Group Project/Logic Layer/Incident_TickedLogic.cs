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

        public List<Incident_Ticket> GetMaxId()
        {
            return dal.GetMaxId();
        }

        public void AddTicket(Incident_Ticket ticket)
        {
            dal.InsertTicket(ticket);
        }
    }
}
