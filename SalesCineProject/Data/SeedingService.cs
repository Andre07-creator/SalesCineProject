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
            if  (_context.Ticket.Any())
            {
                return;
            }

            //Client c1 = new Client("Ricardo", 1);
           // Client c2 = new Client("Paulão", 2);
           // Client c3 = new Client("Richard", 3);

            //SalesRecord sr1 = new SalesRecord(1, DateTime.Now, PaymentForm.Money);
            //SalesRecord sr2 = new SalesRecord(2, DateTime.Now, PaymentForm.Pix);
            //SalesRecord sr3 = new SalesRecord(3, DateTime.Now, PaymentForm.Card);

            //Ticket t1 = new Ticket(1, c1, sr1);
           // Ticket t2 = new Ticket(2, c2, sr2);
            //Ticket t3 = new Ticket(3, c3, sr3);

           // _context.Client.AddRange(c1, c2, c3);
           // _context.SalesRecord.AddRange(sr1, sr2, sr3);
           // _context.Ticket.AddRange(t1, t2, t3);

            _context.SaveChanges();
        }
    }
}
