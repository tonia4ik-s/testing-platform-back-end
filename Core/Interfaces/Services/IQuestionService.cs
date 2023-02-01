using Core.DTO.QuestionDTO;
using Core.Entities;

namespace Core.Interfaces.Services;

public interface IQuestionService
{
    Task<IList<QuestionDTO>> GetAllQuestionsByTestId(int testId);
}