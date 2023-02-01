using AutoMapper;
using Core.DTO.TestDTO;
using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.Services;

namespace Core.Services;

public class TestService : ITestService
{
    private readonly IRepository<Test> _testRepository;
    private readonly IMapper _mapper;

    public TestService(IRepository<Test> testRepository, IMapper mapper)
    {
        _testRepository = testRepository;
        _mapper = mapper;
    }

    public async Task CreateTest(CreateTestDTO createTestDTO)
    {
        var test = _mapper.Map<Test>(createTestDTO);
        float maxRes = 0;
        if (createTestDTO.Questions != null)
        {
            maxRes += createTestDTO.Questions.Sum(question => question.Mark);
        }

        test.MaxResult = maxRes;
        await _testRepository.AddAsync(test);
        await _testRepository.SaveChangesAsync();
    }
}
