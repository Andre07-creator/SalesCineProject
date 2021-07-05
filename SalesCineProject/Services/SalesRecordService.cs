using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCineProject.Models;

namespace SalesCineProject.Services
{
    public class SalesRecordService
    {
        private readonly SalesCineProjectContext _context;

        public SalesRecordService(SalesCineProjectContext context)
        {
            _context = context;
        }

        public List<SalesRecord> FindAll()
        {
            return _context.SalesRecord.ToList();
        }


    }
}
