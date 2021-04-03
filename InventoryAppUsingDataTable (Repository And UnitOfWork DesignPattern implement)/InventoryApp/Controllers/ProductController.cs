using Autofac;
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
            var model = Startup.AutofacContainer.Resolve<CategoryModel>();
            ViewBag.Categories = model.GetAllCategories();
            return View();
        }

        [HttpPost] 
        public IActionResult Create(ProductModel model)
        {
            model.AddProduct();
            return RedirectToAction("GetAll");
        }
        public IActionResult GetAll()
        {
            var model = Startup.AutofacContainer.Resolve<ProductModel>();
            var products = model.GetAllProducts();
            return View(products);
        }
        public IActionResult Edit(int id)
        {
            var categoryModel = Startup.AutofacContainer.Resolve<CategoryModel>();
            var model = Startup.AutofacContainer.Resolve<ProductModel>();
            var product = model.GetProductById(id);

            ViewBag.Categories = categoryModel.GetAllCategories();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var categoryModel = Startup.AutofacContainer.Resolve<CategoryModel>();
            var productModel = Startup.AutofacContainer.Resolve<ProductModel>();
            productModel.UpdateProduct(product);

            ViewBag.Categories = categoryModel.GetAllCategories();
            return RedirectToAction("GetAll");
        }

        public IActionResult Delete(int id)
        {
            var productModel = Startup.AutofacContainer.Resolve<ProductModel>();
            var product = productModel.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            var productModel = Startup.AutofacContainer.Resolve<ProductModel>();
            productModel.RemoveProduct(product);
            return RedirectToAction("GetAll");
        }
    }
}
