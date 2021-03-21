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
       // public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
