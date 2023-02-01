using Core.DTO.TestDTO;

namespace Core.DTO.UserTestDTO;

public class PreviewUserTestDTO
{
    public int TestId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsFinished { get; set; }
    public float Result { get; set; }
}