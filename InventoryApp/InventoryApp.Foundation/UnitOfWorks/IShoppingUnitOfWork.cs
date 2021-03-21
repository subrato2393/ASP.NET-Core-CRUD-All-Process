using InventoryApp.DataAccessLayer;
using InventoryApp.Inventory.Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Inventory.Foundation.UnitOfWorks 
{
    public interface IShoppingUnitOfWork: IUnitOfWork
    {
        IProductRepository ProductRepositroy { get; set; }
        ICategoryRepository CategoryRepository { get; set; }
    }
}
