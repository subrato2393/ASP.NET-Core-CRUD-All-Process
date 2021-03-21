using InventoryApp.Contexts;
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
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                categoryModel.AddCategory();
            }
            return RedirectToAction("GetAll");
        }
        public IActionResult GetAll()
        {
            var model = new CategoryModel();
            var categories = model.GetAllCategories();
            return View(categories);
        }
        public IActionResult Edit(int id)
        {
            var model = new CategoryModel();
            var category = model.GetCategoryById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category model)
        {
            var categoryModel = new CategoryModel();
            categoryModel.UpdateCategory(model);
            return RedirectToAction("GetAll");
        }
        public IActionResult Delete(int id)
        {
            var categoryModel = new CategoryModel();
            var category= categoryModel.GetCategoryById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            var categoryModel = new CategoryModel();
            categoryModel.RemoveCategory(category);
            return RedirectToAction("GetAll");
        }
    }
}
