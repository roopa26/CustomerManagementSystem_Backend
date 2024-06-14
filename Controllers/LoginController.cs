using CustomerManagementSystem_Backend.Models;
using CustomerManagementSystem_Backend.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagementSystem_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public LoginController()
        {
             
        }

        [HttpGet]
        public IActionResult Login(LoginRequest loginData)
        {
            return Ok(loginData);
        }
    }
}
