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

        public SaleTicketsController(TicketService ticketservice)
      
        {
            _ticketservice = ticketservice;            
        }

        public IActionResult Index()
        {
            
            var ticket = _ticketservice.FindAll();
            var viewmodel = new TicketViewModel();


            return View(viewmodel);
        }
    }
}
