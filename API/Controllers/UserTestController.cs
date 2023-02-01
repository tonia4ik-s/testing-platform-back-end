using Core.DTO.UserTestDTO;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class UserTestController : Controller
{
    private readonly IUserTestService _userTestService;
    private readonly IUserService _userService;

    public UserTestController(IUserTestService userTestService, IUserService userService)
    {
        _userTestService = userTestService;
        _userService = userService;
    }
    
    [HttpPost("assign")]
    public async Task<ActionResult> AssignTest([FromBody] AssignTestToUserDTO testToUserDTO)
    {
        await _userTestService.AssignTestToUser(testToUserDTO);
        return Ok();
    }

    [HttpGet]
    public async Task<IList<PreviewUserTestDTO>> GetAllTestAssignedToUser()
    {
        var userId = _userService.GetCurrentUserNameIdentifier(User);
        return await _userTestService.GetAllTestsAssignedToCurrentUser(userId);
    }
}
