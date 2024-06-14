using CustomerManagementSystem_Backend.Engine;
using CustomerManagementSystem_Backend.Models;

namespace CustomerManagementSystem_Backend.Manager
{
    public interface ICustomerManger
    {
        public List<Customer> GetCustomers();
        public Customer GetCustomerById(int id);
        public Customer UpdateCustomers(int id, Customer customer);
        public int? DeleteCustomers(int id);
        public Customer AddCustomer(Customer customer);
    }

    public class CustomerManager : ICustomerManger
    {
        private ICustomerEngine _customerEngine;

        public CustomerManager(ICustomerEngine customerEngine)
        {
            _customerEngine = customerEngine;
        }

        public Customer AddCustomer(Customer customer)
        {
            if (customer == null) 
            {
                throw new ArgumentNullException();
            }
            return _customerEngine.AddCustomer(customer);
        }

        public int? DeleteCustomers(int id)
        {
            if(id == null)
            {
                throw new ArgumentNullException("id");
            }

            return _customerEngine.DeleteCustomers(id);
        }

        public Customer GetCustomerById(int id)
        {
            return _customerEngine.GetCustomerById(id);
        }

        public List<Customer> GetCustomers()
        {
            return _customerEngine.GetCustomers();
        }

        public Customer UpdateCustomers(int id, Customer customer)
        {
            if (customer == null || id == null)
            {
                throw new ArgumentNullException();
            }
            if(id != customer.CustomerId)
            {
                throw new InvalidOperationException();
            }

            return _customerEngine.UpdateCustomers(id,customer);
        }
    }
}
