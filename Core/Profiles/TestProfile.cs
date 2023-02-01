using AutoMapper;
using Core.DTO.TestDTO;
using Core.Entities;

namespace Core.Profiles;

public class TestProfile : Profile
{
    public TestProfile()
    {
        CreateMap<CreateTestDTO, Test>()
            .ReverseMap();
    }
}