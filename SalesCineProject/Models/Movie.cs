using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesCineProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Time)]
        public DateTime Hour { get; set; }
        public Movie()
        {
           
        }

        public Movie(int id, string name, DateTime hour)
        {
            Id = id;
            Name = name;
            Hour = hour;
        }
    }
}
