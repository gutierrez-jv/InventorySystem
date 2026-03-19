using InventorySystem.Models.Database;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Repository.Orders
{
    public class OrdersRepository : IOrdersRepository 
    {
        private readonly InventoryOrderingSystemContext _context;
        public OrdersRepository(InventoryOrderingSystemContext context)
        {
            _context = context;
        }
        public void PlaceOrder(Order order)
        {
            _context.Orders.Add(order);
        }
    }
}
