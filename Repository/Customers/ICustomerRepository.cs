using InventorySystem.Models.Database;

namespace InventorySystem.Repository.Customers
{
    public interface ICustomerRepository
    {
        Task RegisterUser(Customer customer);
        Customer GetCustomer(int customerId);

    }
}
