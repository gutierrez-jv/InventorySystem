using System;
using System.Collections.Generic;

namespace InventorySystem.Models.Database;

public partial class ProductsTable
{
    public int ProductsId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Quantity { get; set; }

    public int Price { get; set; }

    public bool Stock { get; set; }

    public string Barcode { get; set; } = null!;

    public virtual ICollection<OrdersTable> OrdersTables { get; set; } = new List<OrdersTable>();
}
