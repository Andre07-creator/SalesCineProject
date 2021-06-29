using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesCineProject.Models
{
    public class SalesCineProjectContext : DbContext
    {
        public SalesCineProjectContext(DbContextOptions<SalesCineProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
    }
}
