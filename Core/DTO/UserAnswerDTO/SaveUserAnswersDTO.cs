namespace Core.DTO.UserAnswerDTO;

public class SaveUserAnswersDTO
{
    public int UserTestId { get; set; }
    public List<UserAnswerDTO> UserAnswers { get; set; }
}
