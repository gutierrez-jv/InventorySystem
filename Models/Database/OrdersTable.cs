using System;
using System.Collections.Generic;

namespace InventorySystem.Models.Database;

public partial class OrdersTable
{
    public int OrdersId { get; set; }

    public int ProductsId { get; set; }

    public int CustomersId { get; set; }

    public int Quantity { get; set; }

    public int Amount { get; set; }

    public virtual CustomersTable Customers { get; set; } = null!;

    public virtual ProductsTable Products { get; set; } = null!;
}
