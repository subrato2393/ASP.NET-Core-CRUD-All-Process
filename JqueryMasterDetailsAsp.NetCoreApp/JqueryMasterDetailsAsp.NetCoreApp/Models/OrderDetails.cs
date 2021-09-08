using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryMasterDetailsAsp.NetCoreApp.Models
{
    public class OrderDetails
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
