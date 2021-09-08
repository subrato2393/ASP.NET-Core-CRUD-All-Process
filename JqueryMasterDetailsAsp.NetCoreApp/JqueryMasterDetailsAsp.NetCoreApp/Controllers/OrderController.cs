using JqueryMasterDetailsAsp.NetCoreApp.DatabaseContext;
using JqueryMasterDetailsAsp.NetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace JqueryMasterDetailsAsp.NetCoreApp.Controllers
{
    public class OrderController : Controller
    {
        private MasterDbContext _context;
        public OrderController(MasterDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllOrderItem()
        {
            return Json("");
        }

        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(order);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
