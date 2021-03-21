using InventoryApp.DataAccessLayer;
using InventoryApp.Inventory.Foundation.Contexts;
using InventoryApp.Inventory.Foundation.Entities;

namespace InventoryApp.Inventory.Foundation.Repositories
{
    public class CategoryRepository : Repository<Category, int, InventoryDbContext>, ICategoryRepository
    {
        public CategoryRepository(InventoryDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
