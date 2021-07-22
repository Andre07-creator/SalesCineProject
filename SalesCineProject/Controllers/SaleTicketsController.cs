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
    public class SaleTicketsController : Controller
    {

        private readonly TicketService _ticketservice;
        private readonly MovieService _movieservice;

        public SaleTicketsController(TicketService ticketservice, MovieService movieservice)
      
        {
            _ticketservice = ticketservice;
            _movieservice = movieservice;
        }

        public IActionResult Index()
        {
            
            var list = _ticketservice.FindAll();
            return View(list);
        }
        public IActionResult Create()
        {
            var movie = _movieservice.FindAll();
            var viewModels = new TicketViewModel { Movies = movie };
            return View(viewModels);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ticket ticket)
        {
            _ticketservice.Insert(ticket);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _ticketservice.FindById(id.Value);

            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _ticketservice.Remove(id);
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
    }
}
