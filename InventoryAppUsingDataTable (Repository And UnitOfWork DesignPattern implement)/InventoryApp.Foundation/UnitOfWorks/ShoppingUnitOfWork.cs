using InventoryApp.DataAccessLayer;
using InventoryApp.Inventory.Foundation.Contexts;
using InventoryApp.Inventory.Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Inventory.Foundation.UnitOfWorks 
{
    public class ShoppingUnitOfWork:UnitOfWork, IShoppingUnitOfWork
    {
        public IProductRepository ProductRepositroy { get; set; }
        public ICategoryRepository CategoryRepository { get; set; }

        public ShoppingUnitOfWork(InventoryDbContext context,
        IProductRepository productRepositroy,
        ICategoryRepository categoryRepository
        )
        : base(context)
    {
        ProductRepositroy = productRepositroy;
        CategoryRepository = categoryRepository;
    }
}
}
