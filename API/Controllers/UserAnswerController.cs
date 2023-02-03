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

    [HttpGet]
    public async Task<PreviewUserAnswerDTO> GetAllAnswersByUserTestId([FromQuery] int userTestId)
    {
        return await _userAnswerService.GetAllAnswersByUserTestId(userTestId);
    }
}
