using Core.DTO.UserTestDTO;
using Core.Entities;

namespace Core.Interfaces.Services;

public interface IUserTestService
{
    Task AssignTestToUser(AssignTestToUserDTO assignTestToUserDTO);
    Task<IList<PreviewUserTestDTO>> GetAllTestsAssignedToCurrentUser(string userId);
    UserTest? GetUserTestById(int id);
    Task OnFinishUpdate(UserTest userTest, IList<UserAnswer> userAnswers);
}