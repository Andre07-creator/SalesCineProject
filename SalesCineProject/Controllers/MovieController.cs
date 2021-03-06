using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCineProject.Models;
using SalesCineProject.Services;
using SalesCineProject.Services.Exceptions;
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
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _movieservice.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _movieservice.Remove(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _movieservice.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _movieservice.FindById(id);
            if (obj == null)
            {
                return NotFound();
            }
            var viewmodel = new MovieViewModel { Movie = obj };
            return View(viewmodel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }
            try
            {
                _movieservice.Update(movie);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }
    }
}
