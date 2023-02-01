using Core.DTO.UserAnswerDTO;
using Core.Entities;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class UserAnswerController : Controller
{
    private readonly IUserAnswerService _userAnswerService;

    public UserAnswerController(IUserAnswerService userAnswerService)
    {
        _userAnswerService = userAnswerService;
    }

    [HttpPost]
    public async Task<ActionResult> FinishTest([FromBody] SaveUserAnswersDTO userAnswerDTO)
    {
        await _userAnswerService.SaveUserAnswers(userAnswerDTO);
        return Ok();
    }

    [HttpGet("{userTestId:int}")]
    public async Task<List<PreviewUserAnswerDTO>> GetAllAnswersByUserTestId(int userTestId)
    {
        return await _userAnswerService.GetAllAnswersByUserTestId(userTestId);
    }
}
