using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesCineProject.Models
{
    public class Ticket
    {
        const string namemovie = "Homem aranha 2";
        const string hour = "15 hrs";

        public int Id { get; set; }
        public string NameMovie { get; set; }
        public Client Client { get; set; }
        public SalesRecord SalesRecord { get; set; }
        public string Hour { get; set; }

        public Ticket()
        {
        }

        public Ticket(int id, Client client, SalesRecord salesRecord)
        {
            Id = id;
            NameMovie = namemovie;
            Client = client;
            SalesRecord = salesRecord;
            Hour = hour;
        }
    }
}
