using InventoryApp.DataAccessLayer;
using InventoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Inventory.Foundation.Entities
{
    public class Category:IEntity<int>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; } 
    }
}
