namespace Core.DTO.UserAnswerDTO;

public class PreviewQuestionDTO
{
    public string QuestionText { get; set; }
    public float Mark { get; set; }
    public float ResultMark { get; set; }
    public IList<PreviewOptionDTO> Options { get; set; }
}