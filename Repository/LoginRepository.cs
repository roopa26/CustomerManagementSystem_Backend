using CustomerManagementSystem_Backend.DTO;
using CustomerManagementSystem_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementSystem_Backend.Repository
{
    public interface ILoginRepository
    {
        LoginDto GetUserDetails(string userName);
    }
    public class LoginRepository : ILoginRepository
    {
        private CmsContext _context;

        public LoginRepository(CmsContext context)
        {
            _context = context;
        }
        public LoginDto GetUserDetails(string userName)
        {
            var user = (from l in _context.Login
                        select new LoginDto
                        {
                            Username = l.Username,
                            Password = l.Password
                        }).FirstOrDefault();
            return user;
        }
    }
}
