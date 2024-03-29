﻿using InventoryApp.Inventory.Foundation.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Inventory.Foundation.Contexts
{
    public interface IInventoryDbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
    }
}