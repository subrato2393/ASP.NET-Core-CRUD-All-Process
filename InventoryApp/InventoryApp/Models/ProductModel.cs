using Autofac;
using InventoryApp.Inventory.Foundation.Entities;
using InventoryApp.Inventory.Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }

        private readonly IProductService _productService;
        public ProductModel(IProductService productService)
        {
            _productService = productService;
        }
        public ProductModel()
        {
            _productService = Startup.AutofacContainer.Resolve<IProductService>();
        }
        public void AddProduct()
        {
            _productService.AddProductToDatabase(new Product
            {
                CategoryId = CategoryId,
                Price = Price,
                ProductName = ProductName,
                Id = Id
            });
        }
        public IEnumerable<ProductModel> GetAllProducts()
        {
            var productEntity = _productService.GetAllProductsFromDatabase();
            var categories = ConvertProductEntityListToModelList(productEntity);
            return categories;
        }

        private IEnumerable<ProductModel> ConvertProductEntityListToModelList(IList<Product> productEntity)
        {
            var products = productEntity.Select(x => new ProductModel
            {
             CategoryId=x.CategoryId,
             Price=x.Price,
             ProductName=x.ProductName,
             Id=x.Id,
             CategoryName=x.Category.CategoryName
            });
            return products;
        }

        public object GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            var productModel = ConvertProductEntityToProductModel(product);
            return productModel;
        }

        internal void UpdateProduct(Product product)
        {
            _productService.UpdateCategoryInfo(product);
        }

        private ProductModel ConvertProductEntityToProductModel(Product product)
        {
            var productModel = new ProductModel()
            {
                ProductName = product.ProductName,
                Price=product.Price,
                CategoryId=product.CategoryId,
                Id=product.Id,
                CategoryName=product.Category.CategoryName
            };
            return productModel;
        }

        internal void RemoveProduct(Product product)
        {
            _productService.RemoveProduct(product);
        }
    }
}
