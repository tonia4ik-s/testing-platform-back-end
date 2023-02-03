using AutoMapper;
using Core.DTO.UserAnswerDTO;
using Core.Entities;

namespace Core.Profiles;

public class UserAnswerProfile : Profile
{
    public UserAnswerProfile()
    {
        CreateMap<UserAnswerDTO, UserAnswer>().ReverseMap();
        // CreateMap<UserAnswer, PreviewUserAnswerDTO>()
        //     .ForMember(d => d.IsRightAnswer,
        //         opt => opt
        //             .MapFrom(ans => ans.ChosenOption.IsRightAnswer))
        //     .ForMember(d => d.Mark,
        //         opt => opt
        //             .MapFrom(ans => ans.Question.Mark));
    }
}