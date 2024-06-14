using CustomerManagementSystem_Backend.Models;

namespace CustomerManagementSystem_Backend.Repository
{
    public interface ICustomerInterface
    {
        public List<Customer> GetCustomers();
        public Customer GetCustomerById(int id);
        public void AddCustomer(Customer customer);
        public void UpdateCustomer(int id, Customer customer);
        public void DeleteCustomer(int id);
        public Customer GetCustomerById();
    }
}
