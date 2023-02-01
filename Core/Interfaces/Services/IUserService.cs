using System.Security.Claims;
using Core.DTO;

namespace Core.Interfaces.Services;

public interface IUserService
{
    UserDTO GetUserByName(string userName);
    string GetCurrentUserNameIdentifier(ClaimsPrincipal currentUser);
    Task<UserDTO> GetUserById(string userId);
}
