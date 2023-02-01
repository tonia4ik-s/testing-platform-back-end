using AutoMapper;
using Core.DTO.OptionDTO;
using Core.Entities;

namespace Core.Profiles;

public class OptionProfile : Profile
{
    public OptionProfile()
    {
        CreateMap<Option, CreateOptionDTO>().ReverseMap();
    }
}