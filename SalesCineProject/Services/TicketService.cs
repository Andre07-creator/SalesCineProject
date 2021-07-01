using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCineProject.Models;

namespace SalesCineProject.Services
{
    public class TicketService
    {
        private readonly SalesCineProjectContext _context;

        public TicketService(SalesCineProjectContext context)
        {
            _context = context;
        }

        public List<Ticket> FindAll()
        {
            return _context.Ticket.ToList();
        }

    }
}
