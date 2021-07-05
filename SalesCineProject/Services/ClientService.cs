using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCineProject.Models;

namespace SalesCineProject.Services
{
    public class ClientService
    {
        private SalesCineProjectContext _context;

        public ClientService(SalesCineProjectContext context)
        {
            _context = context;
        }

        public List<Client> FindAll()
        {
            return _context.Client.ToList();
        }

    }
}
