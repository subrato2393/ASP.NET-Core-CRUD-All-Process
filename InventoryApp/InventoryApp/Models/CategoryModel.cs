using Autofac;
using InventoryApp.Inventory.Foundation.Entities;
using InventoryApp.Inventory.Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }


        private readonly IProductService _productService;
        public CategoryModel(IProductService productService)
        {
            _productService = productService;
        }
        public CategoryModel()
        {
            _productService = Startup.AutofacContainer.Resolve<IProductService>();
        }
        public void AddCategory()
        {
            _productService.AddCategoryToDatabase(new Category
            {
                CategoryName = CategoryName,
            });
        }

        public IEnumerable<CategoryModel> GetAllCategories()
        {
            var categoryEntity = _productService.GetAllCategoriesFromDatabase();
            var categories = ConvertCategoryEntityListToModelList(categoryEntity);
            return categories;
        }

        public object GetCategoryById(int id)
        {
            var category = _productService.GetCategoryById(id);
            var categoryModel = ConvertCategoryEntityToCategoryModel(category);
            return categoryModel;
        }

        internal void UpdateCategory(Category model)
        {
            _productService.Update(model);
        }

        private CategoryModel ConvertCategoryEntityToCategoryModel(Category category)
        {
            var categoryModel = new CategoryModel()
            {
                Id=category.Id,
                CategoryName = category.CategoryName,
            };
            return categoryModel;
        }

        internal void RemoveCategory(Category category)
        {
            _productService.RemoveCategory(category);
        }

        private IEnumerable<CategoryModel> ConvertCategoryEntityListToModelList(IList<Category> categoryEntity)
        {
            var categoryModelList = categoryEntity.Select(x => new CategoryModel
            {
                Id = x.Id,
                CategoryName = x.CategoryName
            });
            return categoryModelList;
        }
    }
}
