using System;
using System.Collections.Generic;

namespace InventorySystem.Models.Database;

public partial class CustomersTable
{
    public int CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<OrdersTable> OrdersTables { get; set; } = new List<OrdersTable>();
}
