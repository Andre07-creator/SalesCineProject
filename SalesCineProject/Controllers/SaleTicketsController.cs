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
        private readonly SalesRecordService _salesrecordservice;
        private readonly ClientService _clientservice;

        public SaleTicketsController(TicketService ticketservice, 
            SalesRecordService salesrecordservice, ClientService clientservice)
        {
            _ticketservice = ticketservice;
            _salesrecordservice = salesrecordservice;
            _clientservice = clientservice;
        }

        public IActionResult Index()
        {
            
            var ticket = _ticketservice.FindAll();
            var salerecord = _salesrecordservice.FindAll();
            var clientservice = _clientservice.FindAll();
            var viewmodel = new TicketViewModel();


            return View(viewmodel);
        }
    }
}
