using JqueryMasterDetailsAsp.NetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryMasterDetailsAsp.NetCoreApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            return View();
        }
    }
}
