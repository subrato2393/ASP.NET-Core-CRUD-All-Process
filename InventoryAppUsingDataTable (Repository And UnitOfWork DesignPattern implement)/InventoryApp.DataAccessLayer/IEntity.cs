using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp.DataAccessLayer
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
