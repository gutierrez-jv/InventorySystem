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

        public Order PlaceOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
