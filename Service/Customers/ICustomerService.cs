using InventorySystem.Models.Database;
namespace InventorySystem.Service.Customers
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int customerId);
    }
}
