using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCineProject.Models;
using SalesCineProject.Services;
using SalesCineProject.Models.ViewModels;

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
            var viewmodel = new MovieViewModel();
            return View(viewmodel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            _movieservice.Insert(movie);
            return RedirectToAction(nameof(Index));
        }
    }
}
