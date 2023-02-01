using System.Security.Claims;
using AutoMapper;
using Core.DTO;
using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Identity;

namespace Core.Services;

public class UserService : IUserService
{
    private readonly IMapper _mapper;
    private readonly IRepository<User> _userRepository;
    private readonly UserManager<User> _userManager;

    public UserService(IMapper mapper, IRepository<User> userRepository, UserManager<User> userManager)
    {
        _mapper = mapper;
        _userRepository = userRepository;
        _userManager = userManager;
    }
    
    public string GetCurrentUserNameIdentifier(ClaimsPrincipal currentUser)
    {
        return currentUser.FindFirstValue(ClaimTypes.NameIdentifier);
    }

    public async Task<UserDTO> GetUserById(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId); 
        return _mapper.Map<UserDTO>(user);
    }
    
    public UserDTO GetUserByName(string userName)
    {
        var user = _userRepository.Query().First(user => user.UserName.Equals(userName)); 
        return _mapper.Map<UserDTO>(user);
    }
}
