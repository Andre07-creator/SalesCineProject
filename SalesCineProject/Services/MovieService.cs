﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SalesCineProject.Models;
using Microsoft.EntityFrameworkCore;

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


        public void Insert(Movie obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }


        public Movie FindById(int? id)
        {
            return _context.Movie.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Movie.Find(id);
            _context.Remove(obj);
            _context.SaveChanges();
        }
    }
}
