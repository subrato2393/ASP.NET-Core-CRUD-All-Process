using InventoryApp.Inventory.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Inventory.Foundation.Services
{
    public interface IProductService
    {
        void AddProductToDatabase(Category category);
        IList<Category> GetAllCategoriesFromDatabase();
        Category GetCategoryById(int id);
        void Update(Category model);
        void RemoveCategory(Category category);
    }
}
