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
    private readonly IMapper _mapper;
    private readonly IUserTestService _userTestService;

    public UserAnswerService(
        IRepository<UserAnswer> userAnswerRepository, 
        IMapper mapper, 
        IUserTestService userTestService,
        IRepository<Option> optionRepository,
        IRepository<Question> questionRepository)
    {
        _userAnswerRepository = userAnswerRepository;
        _mapper = mapper;
        _userTestService = userTestService;
        _optionRepository = optionRepository;
        _questionRepository = questionRepository;
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
        
        // var userAnswersList = new List<UserAnswer>();
        // foreach (var userAnswer in userAnswersDTO.UserAnswers.Select(answer => 
        //              new UserAnswer { 
        //                  ChosenOptionId = answer.ChosenOptionId,
        //                  QuestionId = answer.QuestionId,
        //                  UserTestId = answer.UserTestId }))
        // {
        //     userAnswersList.Add(userAnswer);
        //     await _userAnswerRepository.AddAsync(userAnswer);
        //     await _userAnswerRepository.SaveChangesAsync();
        // }
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
        // var answers = await GetAllAnswersByUserTestId(userTest.Id);
        await _userTestService.OnFinishUpdate(userTest, userAnswers);
    }

    // public async Task SaveUserAnswer(UserAnswerDTO userAnswerDTO)
    // {
    //     var answer = _mapper.Map<UserAnswer>(userAnswerDTO);
    //     var answerToDelete = await _userAnswerRepository.Query()
    //         .FirstOrDefaultAsync(a => a.QuestionId == answer.QuestionId);
    //     if (answerToDelete != null) await _userAnswerRepository.DeleteAsync(answerToDelete);
    //     answer.Question = await _questionRepository.Query().FirstOrDefaultAsync(q => q.Id == answer.QuestionId);
    //     answer.ChosenOption = await _optionRepository.Query().FirstOrDefaultAsync(o => o.Id == answer.ChosenOptionId);
    //     await _userAnswerRepository.AddAsync(answer);
    //     await _userAnswerRepository.SaveChangesAsync();
    // }
    
    public async Task<List<PreviewUserAnswerDTO>> GetAllAnswersByUserTestId(int userTestId)
    {
        var userAnswers = await _userAnswerRepository.Query()
            .Where(a => a.UserTestId == userTestId).ToListAsync();
        return userAnswers.Select(a => _mapper.Map<PreviewUserAnswerDTO>(a)).ToList();
    }
}
