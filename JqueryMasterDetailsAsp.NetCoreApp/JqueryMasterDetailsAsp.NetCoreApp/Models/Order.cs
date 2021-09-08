using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryMasterDetailsAsp.NetCoreApp.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
