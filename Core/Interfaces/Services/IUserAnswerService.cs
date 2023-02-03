using Core.DTO.UserAnswerDTO;
using Core.Entities;

namespace Core.Interfaces.Services;

public interface IUserAnswerService
{
    Task SaveUserAnswers(SaveUserAnswersDTO userAnswersDTO);
    Task<PreviewUserAnswerDTO> GetAllAnswersByUserTestId(int userTestId);
}