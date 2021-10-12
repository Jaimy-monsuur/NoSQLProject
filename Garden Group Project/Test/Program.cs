using System;
using DAL;
using MongoDB.Bson;
using Model;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Incident_TicketDAL insident_TicketDAL = new Incident_TicketDAL();
            foreach (Incident_Ticket item in insident_TicketDAL.GetAllTicketsFromFilter())
            {
                Console.WriteLine(item.objectId);
                Console.WriteLine(item.id);
                Console.WriteLine(item.Status);
            }

        }
    }
}
