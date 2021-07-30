using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCineProject.Models;
using SalesCineProject.Services;

namespace SalesCineProject.Controllers
{
    public class MovieController : Controller
    {
        public readonly MovieService _movieservice;

        public MovieController(MovieService movieservice)
        {
            _movieservice = movieservice;
        }

        public IActionResult Index()
        {
            var List = _movieservice.FindAll();
            return View(List);
        }
        public IActionResult Create()
        {
            var movie = _movieservice.FindAll();
            return View(movie);
        }
    }
}
