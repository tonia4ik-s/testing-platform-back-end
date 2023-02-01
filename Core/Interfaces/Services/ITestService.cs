using Core.DTO.TestDTO;
using Core.Entities;

namespace Core.Interfaces.Services;

public interface ITestService
{
    Task CreateTest(CreateTestDTO createTestDTO);
}