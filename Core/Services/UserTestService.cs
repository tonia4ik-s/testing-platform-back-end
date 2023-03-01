using AutoMapper;
using Core.DTO.TestDTO;
using Core.DTO.UserTestDTO;
using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

namespace Core.Services;

public class UserTestService : IUserTestService
{
    private readonly IRepository<UserTest> _userTestRepository;
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserTestService(
        IRepository<UserTest> userTestRepository, 
        IUserService userService, 
        IMapper mapper)
    {
        _userTestRepository = userTestRepository;
        _userService = userService;
        _mapper = mapper;
    }
    
    public async Task AssignTestToUser(AssignTestToUserDTO assignTestToUserDTO)
    {
        var user = _userService.GetUserByName(assignTestToUserDTO.UserName);
        var userTest = new UserTest
        {
            AssignedToId = user.Id,
            TestId = assignTestToUserDTO.TestId,
            IsFinished = false
        };
        await _userTestRepository.AddAsync(userTest);
        await _userTestRepository.SaveChangesAsync();
    }

    public async Task<IList<PreviewUserTestDTO>> GetAllTestsAssignedToCurrentUser(string userId)
    {
        var tests = await _userTestRepository.Query()
            .Where(t => t.AssignedToId == userId)
            .Include(t => t.Test)
            .ToListAsync();
        return tests.Select(test => _mapper.Map<PreviewUserTestDTO>(test)).ToList();
    }

    public UserTest? GetUserTestById(int id)
    {
        return _userTestRepository.Query().FirstOrDefault(t => t.Id == id && t.IsFinished == false);
    }

    public async Task OnFinishUpdate(UserTest userTest, IList<UserAnswer> userAnswers)
    {
        userTest.IsFinished = true;

        userTest.Result = userAnswers
            .Where(userAnswer => userAnswer.ChosenOption.IsRightAnswer)
            .Sum(userAnswer => userAnswer.Question.Mark);

        await _userTestRepository.UpdateAsync(userTest);
        await _userTestRepository.SaveChangesAsync();
    }
}
