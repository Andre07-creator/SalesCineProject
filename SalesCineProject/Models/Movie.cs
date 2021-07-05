using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesCineProject.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public DateTime Hour { get; set; }

        public Movie()
        {
           
        }

        public Movie(string name, DateTime hour)
        {
            Name = name;
            Hour = hour;
        }
    }
}
