using InventorySystem.Models.Database;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Repository.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly InventoryOrderingSystemContext _context;

        public CustomerRepository(InventoryOrderingSystemContext context)
        {
            _context = context;
        }
        public Customer? GetCustomer(int customerId)
        {
            return  _context.Customers.Find(customerId);
        }

        public Task RegisterUser(Customer customer)
        {
            _context.Customers.Add(customer);
            return _context.SaveChangesAsync();
        }
    }
}
