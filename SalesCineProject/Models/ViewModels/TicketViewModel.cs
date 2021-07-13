using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCineProject.Models;

namespace SalesCineProject.Models.ViewModels
{
    public class TicketViewModel
    {
        public Ticket Ticket { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }

}
