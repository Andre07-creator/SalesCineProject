using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCineProject.Models;
using Microsoft.EntityFrameworkCore;
using SalesCineProject.Services.Exceptions;

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
        public void Insert(Ticket obj)
        {
           
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Ticket FindById(int? id)
        {
            return _context.Ticket.Include(obj => obj.Movie).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Ticket.Find(id);
            _context.Ticket.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Ticket obj)
        {
            if(!_context.Ticket.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
