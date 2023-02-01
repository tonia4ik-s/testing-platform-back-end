using AutoMapper;
using Core.DTO;
using Core.Entities;


namespace Core.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserRegistrationDTO>().ReverseMap();
        CreateMap<User, UserDTO>().ReverseMap();
    }
}
