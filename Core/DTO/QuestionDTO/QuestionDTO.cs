using Core.DTO.OptionDTO;

namespace Core.DTO.QuestionDTO;

public class QuestionDTO
{
    public int Id { get; set; }
    public string QuestionText { get; set; }
    public float Mark { get; set; }
    public IList<CreateOptionDTO>? Options { get; set; }
}