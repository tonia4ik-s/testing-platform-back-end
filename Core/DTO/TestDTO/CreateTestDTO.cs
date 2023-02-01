using Core.DTO.QuestionDTO;

namespace Core.DTO.TestDTO;

public class CreateTestDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public IList<QuestionDTO.QuestionDTO>? Questions { get; set; }
}