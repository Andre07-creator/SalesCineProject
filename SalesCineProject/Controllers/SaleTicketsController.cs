using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesCineProject.Controllers
{
    public class SaleTicketsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
