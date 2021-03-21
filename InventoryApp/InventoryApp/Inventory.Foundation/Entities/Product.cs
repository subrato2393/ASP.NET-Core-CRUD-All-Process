using InventoryApp.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Inventory.Foundation.Entities
{
    public class Product:IEntity<int>
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public virtual Category Category { get; set; }
        public  int CategoryId { get; set; } 
    }
}
