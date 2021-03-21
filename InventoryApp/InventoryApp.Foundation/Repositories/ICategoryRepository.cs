using InventoryApp.DataAccessLayer;
using InventoryApp.Inventory.Foundation.Contexts;
using InventoryApp.Inventory.Foundation.Entities;


namespace InventoryApp.Inventory.Foundation.Repositories
{
    public interface ICategoryRepository: IRepository<Category, int, InventoryDbContext>
    {

    }
}
