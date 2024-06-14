using CustomerManagementSystem_Backend.Manager;
using CustomerManagementSystem_Backend.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerManagementSystem_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomerManger _customerManager;

        public CustomersController(ICustomerManger customerManager)
        {
            _customerManager = customerManager;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public IActionResult Get()
        {
            var response = _customerManager.GetCustomers();
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("{id}", Name = "GetCustomerById")]
        public IActionResult GetCustomerById()
        {
            var response = _customerManager.GetCustomers();
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }


        // POST api/<CustomersController>
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            var response = _customerManager.AddCustomer(customer);
            if (response == null)
            {
                return NotFound();
            }
            var location = Url.Link("GetCustomerById", new { id = response.CustomerId });
            return Created(location, response);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Customer customer)
        {
            var response = _customerManager.UpdateCustomers(id, customer);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var response = _customerManager.DeleteCustomers(id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
