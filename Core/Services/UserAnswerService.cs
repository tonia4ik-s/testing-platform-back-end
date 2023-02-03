using AutoMapper;
using Core.DTO.UserAnswerDTO;
using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.Services;
using System.Net;
using Core.Exceptions;
using Microsoft.EntityFrameworkCore;


namespace Core.Services;

public class UserAnswerService : IUserAnswerService
{
    private readonly IRepository<UserAnswer> _userAnswerRepository;
    private readonly IRepository<Question> _questionRepository;
    private readonly IRepository<Option> _optionRepository;
    private readonly IRepository<Test> _testRepository;
    private readonly IMapper _mapper;
    private readonly IUserTestService _userTestService;

    public UserAnswerService(
        IRepository<UserAnswer> userAnswerRepository, 
        IMapper mapper, 
        IUserTestService userTestService,
        IRepository<Option> optionRepository,
        IRepository<Question> questionRepository, IRepository<Test> testRepository)
    {
        _userAnswerRepository = userAnswerRepository;
        _mapper = mapper;
        _userTestService = userTestService;
        _optionRepository = optionRepository;
        _questionRepository = questionRepository;
        _testRepository = testRepository;
    }

    public async Task SaveUserAnswers(SaveUserAnswersDTO userAnswersDTO)
    {
        var userTest = _userTestService.GetUserTestById(userAnswersDTO.UserTestId);
        if (userTest == null)
        {
            throw new HttpException("There no such test assigned to user.",
                HttpStatusCode.NotFound);
        }
    
        var answersToDelete = _userAnswerRepository.Query()
            .Where(p => p.UserTestId == userAnswersDTO.UserTestId).ToList();
        await _userAnswerRepository.DeleteRange(answersToDelete);
        
        var userAnswers = _mapper
            .ProjectTo<UserAnswer>(userAnswersDTO.UserAnswers.AsQueryable())
            .ToList();
        foreach (var answer in userAnswers)
        {
            answer.Question = await _questionRepository.Query().FirstOrDefaultAsync(q => q.Id == answer.QuestionId);
            answer.ChosenOption = await _optionRepository.Query().FirstOrDefaultAsync(o => o.Id == answer.ChosenOptionId);
        }
        await _userAnswerRepository.AddRangeAsync(userAnswers);
        await _userAnswerRepository.SaveChangesAsync();
        await _userTestService.OnFinishUpdate(userTest, userAnswers);
    }

    public async Task<PreviewUserAnswerDTO> GetAllAnswersByUserTestId(int userTestId)
    {
        var userTest = _userTestService.GetUserTestById(userTestId);
        if (userTest == null)
        {
            throw new HttpException("There no such test assigned to user.",
                HttpStatusCode.NotFound);
        }

        if (!userTest.IsFinished)
        {
            throw new HttpException("Test wasn't finished yet.",
                HttpStatusCode.BadRequest);
        }
        var test = (await _testRepository.Query().Where(t => t.Id == userTest.TestId)
            .Include(t => t.Questions)
            .ThenInclude(q => q.Options).ToListAsync())[0];
        
        var questions = new List<PreviewQuestionDTO>();
        foreach (var question in test.Questions)
        {
            var userAnswerId = _userAnswerRepository.Query()
                .FirstOrDefault(ans => ans.QuestionId == question.Id)!.ChosenOptionId;
            var q = new PreviewQuestionDTO
            {
                QuestionText = question.QuestionText,
                Mark = question.Mark,
                ResultMark = question.Options
                    .FirstOrDefault(opt => opt.IsRightAnswer)!.Id == userAnswerId ?
                    question.Mark : 0.0f,
                Options = question.Options.Select(option => 
                    new PreviewOptionDTO
                    {
                        OptionText = option.OptionText,
                        isRightAnswer = option.IsRightAnswer,
                        isUserAnswer = option.Id == userAnswerId
                    }).ToList()
            };
            questions.Add(q);
        }

        return new PreviewUserAnswerDTO
        {
            TestTitle = test.Title,
            MaxResult = test.MaxResult,
            Result = userTest.Result,
            Questions = questions
        };
    }
}
