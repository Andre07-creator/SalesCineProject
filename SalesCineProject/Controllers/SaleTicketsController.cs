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
    }
}
