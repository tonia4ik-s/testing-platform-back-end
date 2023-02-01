using AutoMapper;
using Core.DTO.UserTestDTO;
using Core.Entities;

namespace Core.Profiles;

public class UserTestProfile : Profile
{
    public UserTestProfile()
    {
        CreateMap<UserTest, PreviewUserTestDTO>()
            .ForMember(d => d.Title,
                opt => opt
                    .MapFrom(userTest => userTest.Test.Title))
            .ForMember(d => d.Description,
                opt => opt
                    .MapFrom(userTest => userTest.Test.Description));
    }
}