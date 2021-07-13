using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SalesCineProject.Models;

namespace SalesCineProject.Services
{
    public class MovieService
    {
        private readonly SalesCineProjectContext _context;

        public MovieService(SalesCineProjectContext context)
        {
            _context = context;
        }

        public List<Movie> FindAll()
        {
            return _context.Movie.OrderBy(x => x.Name).ToList();
        }
    }
}
