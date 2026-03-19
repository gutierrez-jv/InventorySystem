using InventorySystem.Models.Database;

namespace InventorySystem.Service.Orders
{
    public interface IOrdersService
    {
        void PlaceOrder(InventorySystem.Models.Database.Order order);
    }
}
