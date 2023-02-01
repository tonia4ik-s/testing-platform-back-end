using Core.DTO.TestDTO;
using Core.DTO.UserTestDTO;
using Core.Entities;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class TestController : Controller
{
    private readonly ITestService _testService;

    public TestController(ITestService testService)
    {
        _testService = testService;
    }

    
    [HttpPost("create")]
    public async Task<ActionResult> CreateTest([FromBody] CreateTestDTO createTestDTO)
    {
        await _testService.CreateTest(createTestDTO);
        return Ok();
    }
}
