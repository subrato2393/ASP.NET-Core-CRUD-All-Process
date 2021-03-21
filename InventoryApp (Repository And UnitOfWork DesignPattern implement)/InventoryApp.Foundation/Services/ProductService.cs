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
        public void AddCategoryToDatabase(Category category)
        {
            _shopingUnitOfWork.CategoryRepository.Add(category);
            _shopingUnitOfWork.Save();
        }
        public void AddProductToDatabase(Product product)
        {
            _shopingUnitOfWork.ProductRepositroy.Add(product);
            _shopingUnitOfWork.Save();
        }

        public IList<Category> GetAllCategoriesFromDatabase()
        {
            var categories= _shopingUnitOfWork.CategoryRepository.GetAll();
            return categories;
        }

        public IList<Product> GetAllProductsFromDatabase()
        {
            var products = _shopingUnitOfWork.ProductRepositroy.GetAll();
            return products;
        }

        public Category GetCategoryById(int id)
        {
            var category = _shopingUnitOfWork.CategoryRepository.GetById(id);
            return category;
        }

        public Product GetProductById(int id)
        {
            var product = _shopingUnitOfWork.ProductRepositroy.GetById(id);
            return product;
        }

        public void RemoveCategory(Category category)
        {
            var categoryEntity = _shopingUnitOfWork.CategoryRepository.GetById(category.Id);

            _shopingUnitOfWork.CategoryRepository.Remove(categoryEntity);
            _shopingUnitOfWork.Save();
        }

        public void RemoveProduct(Product product)
        {
             var productEntity = _shopingUnitOfWork.ProductRepositroy.GetById(product.Id);

            _shopingUnitOfWork.ProductRepositroy.Remove(productEntity);
            _shopingUnitOfWork.Save();
        }

        public void Update(Category model)
        {
            var category = _shopingUnitOfWork.CategoryRepository.GetById(model.Id);
            category.CategoryName = model.CategoryName;
            _shopingUnitOfWork.Save();
        }
        public void UpdateCategoryInfo(Product product)
        {
            var producEntity = _shopingUnitOfWork.ProductRepositroy.GetById(product.Id);
           
            producEntity.CategoryId = product.CategoryId;
            producEntity.Price = product.Price;
            producEntity.ProductName = product.ProductName;
           
            _shopingUnitOfWork.Save(); 
        }
    } 
}
