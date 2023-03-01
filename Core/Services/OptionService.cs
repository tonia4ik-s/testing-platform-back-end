using AutoMapper;
using Core.DTO.OptionDTO;
using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.Services;

namespace Core.Services;

public class OptionService : IOptionService
{
    private readonly IRepository<Option> _optionsRepository;
    private readonly IMapper _mapper;

    public OptionService(IRepository<Option> optionsRepository, IMapper mapper)
    {
        _optionsRepository = optionsRepository;
        _mapper = mapper;
    }

    public async Task CreateOption(CreateOptionDTO createOptionDTO, int questionId)
    {
        var option = _mapper.Map<Option>(createOptionDTO);
        option.QuestionId = questionId;
        await _optionsRepository.AddAsync(option);
        await _optionsRepository.SaveChangesAsync();
    }
}
