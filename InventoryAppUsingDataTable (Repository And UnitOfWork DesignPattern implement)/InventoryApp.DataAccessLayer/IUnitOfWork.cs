using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp.DataAccessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
