using AutoMapper;
using Core.DTO.QuestionDTO;
using Core.Entities;

namespace Core.Profiles;

public class QuestionProfile : Profile
{
    public QuestionProfile()
    {
        CreateMap<Question, QuestionDTO>();
    }
}