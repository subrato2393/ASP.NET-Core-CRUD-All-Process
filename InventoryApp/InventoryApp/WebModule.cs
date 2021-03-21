using Autofac;
using InventoryApp.Inventory.Foundation.Repositories;
using InventoryApp.Inventory.Foundation.Services;
using InventoryApp.Inventory.Foundation.UnitOfWorks;
using InventoryApp.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<ShoppingUnitOfWork>().As<IShoppingUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryModel>().AsSelf();

            base.Load(builder);
        }
    }
}
