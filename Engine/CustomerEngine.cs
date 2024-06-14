using CustomerManagementSystem_Backend.Models;
using CustomerManagementSystem_Backend.Repository;

namespace CustomerManagementSystem_Backend.Engine
{
    public interface ICustomerEngine
    {
        public List<Customer> GetCustomers();
        public Customer GetCustomerById(int id);
        public Customer UpdateCustomers(int id,Customer customer);
        public int? DeleteCustomers(int id);
        public Customer AddCustomer(Customer customer);
    }
    public class CustomerEngine : ICustomerEngine
    {
        private ICustomerInterface _customerRepo;

        public CustomerEngine(ICustomerInterface customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public Customer AddCustomer(Customer customer)
        {
            try
            {
                _customerRepo.AddCustomer(customer);
                return customer;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public int? DeleteCustomers(int id)
        {
            try
            {
                _customerRepo.DeleteCustomer(id);
                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public Customer GetCustomerById(int id)
        {
            try
            {
                return _customerRepo.GetCustomerById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to fetch customers ", ex.ToString());
            }
            return null;
        }

        public List<Customer> GetCustomers()
        {
            try
            {
                return _customerRepo.GetCustomers();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Failed to fetch customers ", ex.ToString());
            }
            return null;
            
        }

        public Customer UpdateCustomers(int id, Customer customer)
        {
            try
            {
                _customerRepo.UpdateCustomer(id, customer);
                return customer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
