using AutoMapper;
using Core.DTO.QuestionDTO;
using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

namespace Core.Services;

public class QuestionService : IQuestionService
{
    private readonly IRepository<Question> _questionRepository;
    private readonly IOptionService _optionService;
    private readonly IMapper _mapper;

    public QuestionService(
        IRepository<Question> questionRepository,
        IOptionService optionService,
        IMapper mapper)
    {
        _questionRepository = questionRepository;
        _optionService = optionService;
        _mapper = mapper;
    }
    
    public async Task<IList<QuestionDTO>> GetAllQuestionsByTestId(int testId)
    {
        var questions = await _questionRepository.Query()
            .Where(q => q.TestId == testId)
            .Include(q => q.Options)
            .ToListAsync();
        return questions.Select(question => _mapper.Map<QuestionDTO>(question)).ToList();
    }
}