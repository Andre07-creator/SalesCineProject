using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesCineProject.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string NameMovie { get; set; }
        public Client Client { get; set; }
        public SalesRecord SalesRecord { get; set; }

        public Ticket()
        {
        }

        public Ticket(int id, string nameMovie, Client client, SalesRecord salesRecord)
        {
            Id = id;
            NameMovie = nameMovie;
            Client = client;
            SalesRecord = salesRecord;
        }
    }
}
