using InventoryApp.Contexts;
using InventoryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly InventoryDbContext _context;
        public CategoryController(InventoryDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                _context.SaveChanges();
            }
            return RedirectToAction("GetAll");
        }
        public IActionResult GetAll()
        {
            var categories= _context.Categories.ToList();
            return View(categories);
        }
        public IActionResult Edit(int id)
        {
            var model = _context.Categories.Find(id);
            return View(model);
        }
        
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _context.Entry<Category>(category).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        public IActionResult Delete(int id)
        {
            var model = _context.Categories.Find(id);
            return View(model);
        }

        [HttpPost] 
        public IActionResult Delete(Category category)
        {
            var model = _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("GetAll"); 
        }
    }
}
