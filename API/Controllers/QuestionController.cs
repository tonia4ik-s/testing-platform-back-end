using Core.DTO.QuestionDTO;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class QuestionController : Controller
{
    private readonly IQuestionService _questionService;

    public QuestionController(IQuestionService questionService)
    {
        _questionService = questionService;
    }

    [HttpGet("{testId:int}")]
    public async Task<IList<QuestionDTO>> GetAllQuestionsByTestId(int testId)
    {
        return await _questionService.GetAllQuestionsByTestId(testId);
    }
}
