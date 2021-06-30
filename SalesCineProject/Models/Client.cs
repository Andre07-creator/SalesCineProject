using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesCineProject.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Client()
        {
        }

        public Client( string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
