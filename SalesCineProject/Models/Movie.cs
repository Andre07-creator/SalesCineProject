using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesCineProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Hour { get; set; }
        public Ticket Ticket { get; set; }

        public Movie()
        {
           
        }

        public Movie(int id, string name, DateTime hour, Ticket ticket)
        {
            Id = id;
            Name = name;
            Hour = hour;
            Ticket = ticket;
        }
    }
}
