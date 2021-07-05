using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesCineProject.Models
{
    public class Ticket
    {
        const string namemovie = "Homem aranha 2";
        const int hour = 15 ;

        public int Id { get; set; }
        public string NameMovie { get; set; }
        public int ClientId { get; set; }
        public int SalesRecordId { get; set; }
        public int Hour { get; set; }

        public Ticket()
        {
        }

        public Ticket(int id)
        {
            Id = id;
            NameMovie = namemovie;
            Hour = hour;
        }
    }
}
