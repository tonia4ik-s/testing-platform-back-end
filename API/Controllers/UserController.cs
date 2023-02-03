using Core.DTO;
using Core.Entities;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class UserController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly IHttpContextAccessor _contextAccessor;
    private readonly IUserService _userService;

    public UserController(UserManager<User> manager, IHttpContextAccessor contextAccessor, IUserService userService)
    {
        _userManager = manager;
        _contextAccessor = contextAccessor;
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<UserDTO>> GetCurrentUser()
    {
        var userId = _userService.GetCurrentUserNameIdentifier(User);
        var user = await _userService.GetUserById(userId);
        return Ok(user);
    }
}
