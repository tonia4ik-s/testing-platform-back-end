using Core.DTO;

namespace Core.Interfaces.Services;

public interface IAuthenticationService
{
    Task<UserAuthorizationDTO> RegisterAsync(UserRegistrationDTO data);
    Task<UserAuthorizationDTO> LoginAsync(UserLoginDTO data);
    Task<UserAuthorizationDTO> RefreshTokenAsync(UserAuthorizationDTO userTokensDTO);
    Task LogoutAsync(UserLogoutDTO userLogoutDTO);
}
