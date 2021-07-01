using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCineProject.Models;
using SalesCineProject.Services;

namespace SalesCineProject.Controllers
{
    public class SaleTicketsController : Controller
    {

        private readonly TicketService _ticket;

        public SaleTicketsController(TicketService ticket)
        {
            _ticket = ticket;
        }

        public IActionResult Index()
        {

            var list = _ticket.FindAll();

            return View(list);
        }
    }
}
