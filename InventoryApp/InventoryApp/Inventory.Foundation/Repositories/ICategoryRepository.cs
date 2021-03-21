using InventoryApp.Contexts;
using InventoryApp.DataAccessLayer;
using InventoryApp.Inventory.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Inventory.Foundation.Repositories
{
    public interface ICategoryRepository: IRepository<Category, int, InventoryDbContext>
    {

    }
}
