using InventorySystem.Models.Database;
using InventorySystem.Repository.Customers;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Service.Customers
{
    public class CustomersService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomersService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public Customer GetCustomerById(int customerId)
        {
            if (customerId <= 0) throw new ArgumentException("Customer ID must be greater than zero.");
            return _customerRepository.GetCustomer(customerId);
        }
    }
}
