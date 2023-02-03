namespace Core.DTO.UserAnswerDTO;

public class PreviewOptionDTO
{
    public string OptionText { get; set; }
    public bool isRightAnswer { get; set; }
    public bool isUserAnswer { get; set; } = false;
}