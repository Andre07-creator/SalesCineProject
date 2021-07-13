using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCineProject.Models;
using SalesCineProject.Models.Enums;
namespace SalesCineProject.Data
{
    public class SeedingService
    {
        private SalesCineProjectContext _context;

        public SeedingService(SalesCineProjectContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if  (_context.Ticket.Any() || _context.Movie.Any())
            {
                return;
            }


            Ticket t1 = new Ticket(1, "Paulão", 20, PaymentForm.Card);
            Ticket t2 = new Ticket(2, "Ana", 20,  PaymentForm.Money);
            Ticket t3 = new Ticket(3, "Julia", 20,  PaymentForm.Pix);

            Movie m1 = new Movie(1, "Homen aranha 3", new DateTime(2021, 7, 10, 15, 0, 0), t1);
            Movie m2 = new Movie(2, "Batman", new DateTime(2, 7, 10, 18, 0, 0), t2);
            Movie m3 = new Movie(3, "Truman show", new DateTime(2021, 7, 10, 10, 0, 0), t3);

            _context.Ticket.AddRange(t1, t2, t3);
            _context.Movie.AddRange(m1, m2, m3);

            _context.SaveChanges();
        }
    }
}
