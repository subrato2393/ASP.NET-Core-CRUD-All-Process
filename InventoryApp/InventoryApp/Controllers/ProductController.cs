using InventoryApp.Inventory.Foundation.Contexts;
using InventoryApp.Inventory.Foundation.Entities;
using InventoryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly InventoryDbContext _context;
        public ProductController(InventoryDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost] 
        public IActionResult Create(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
         
            ViewBag.Categories = _context.Categories.ToList();
            return RedirectToAction("GetAll");
        }
        public IActionResult GetAll()
        {
           var model= _context.Products.ToList();
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var product=  _context.Products.Find(id);
           
            ViewBag.Categories = _context.Categories.ToList();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _context.Entry<Product>(product).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("GetAll");
        }

        public IActionResult Delete(int id)
        {
            var model = _context.Products.Find(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            var model = _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}
