using InventorySystem.Models.Database;

namespace InventorySystem.Repository.Orders
{
    public interface IOrdersRepository
    {
        void PlaceOrder(Order order);
    }
}
