using InventoryApp.Inventory.Foundation.Entities;
using InventoryApp.Inventory.Foundation.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Inventory.Foundation.Services
{
    public class ProductService:IProductService
    {
        private readonly IShoppingUnitOfWork _shopingUnitOfWork;
        public ProductService(IShoppingUnitOfWork shopingUnitOfWork)
        {
            _shopingUnitOfWork = shopingUnitOfWork;
        }
        public void AddProductToDatabase(Category category)
        {
            _shopingUnitOfWork.CategoryRepository.Add(category);
            _shopingUnitOfWork.Save();
        }

        public IList<Category> GetAllCategoriesFromDatabase()
        {
            var categories= _shopingUnitOfWork.CategoryRepository.GetAll();
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            var category = _shopingUnitOfWork.CategoryRepository.GetById(id);
            return category;
        }

        public void RemoveCategory(Category category)
        {
            var categoryEntity = _shopingUnitOfWork.CategoryRepository.GetById(category.Id);

            _shopingUnitOfWork.CategoryRepository.Remove(categoryEntity);
            _shopingUnitOfWork.Save();
        }

        public void Update(Category model)
        {
            var category = _shopingUnitOfWork.CategoryRepository.GetById(model.Id);
            category.CategoryName = model.CategoryName;
            _shopingUnitOfWork.Save();
        }

    } 
}
