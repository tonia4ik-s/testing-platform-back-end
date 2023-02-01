namespace Core.DTO.UserAnswerDTO;

public class PreviewUserAnswerDTO
{
    public int UserTestId { get; set; }
    public int QuestionId { get; set; }
    public int ChosenOptionId { get; set; }
    public bool IsRightAnswer { get; set; }
    public float Mark { get; set; }
}