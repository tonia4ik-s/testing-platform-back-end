namespace Core.DTO.UserAnswerDTO;

public class PreviewUserAnswerDTO
{
    public string TestTitle { get; set; }
    public float MaxResult { get; set; }
    public float Result { get; set; }
    public IList<PreviewQuestionDTO> Questions { get; set; }
}