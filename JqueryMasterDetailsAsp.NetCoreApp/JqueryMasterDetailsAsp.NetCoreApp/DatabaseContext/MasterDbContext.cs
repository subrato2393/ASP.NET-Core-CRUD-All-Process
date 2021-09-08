using JqueryMasterDetailsAsp.NetCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryMasterDetailsAsp.NetCoreApp.DatabaseContext
{
    public class MasterDbContext :DbContext
    {
        public MasterDbContext(DbContextOptions<MasterDbContext> options)
         : base(options)
        {
             
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
