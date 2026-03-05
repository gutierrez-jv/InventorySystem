using InventorySystem.Models.Database;

namespace InventorySystem.Repository.Orders
{
    public interface IOrdersRepository
    {
        Order PlaceOrder(Order order);
    }
}
