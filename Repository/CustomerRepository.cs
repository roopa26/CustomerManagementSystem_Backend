using CustomerManagementSystem_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementSystem_Backend.Repository
{
    public class CustomerRepository : ICustomerInterface
    {
        private CmsContext _context;

        public CustomerRepository(CmsContext context)
        {
            _context = context;
        }
        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var customerExisting = _context.Customers.Find(id);
            if (customerExisting != null)
            {
                _context.Customers.Remove(customerExisting);
                _context.SaveChanges();
            }
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.Find(id);
        }

        public Customer GetCustomerById()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public void UpdateCustomer(int id, Customer customer)
        {
            var customerExisting = _context.Customers.Find(id);
            if (customerExisting != null)
            {
                _context.Entry(customerExisting).CurrentValues.SetValues(customer);
                _context.SaveChanges();
            }
        }
    }
}
