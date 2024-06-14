using AutoMapper;
using CustomerManagementSystem_Backend.DTO;
using CustomerManagementSystem_Backend.ResponseModel;

namespace CustomerManagementSystem_Backend.Profiles
{
    public class LoginProfile : Profile
    {
        public LoginProfile() 
        {
            CreateMap<LoginDto, LoginResponse>()
                .ForMember(dest=>dest.UserName,opt=>opt.MapFrom(src=>src.Username));
        }
    }
}
