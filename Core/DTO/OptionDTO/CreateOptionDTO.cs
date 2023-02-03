namespace Core.DTO.OptionDTO;

public class CreateOptionDTO
{
    public int Id { get; set; }
    public string OptionText { get; set; }
    public bool IsRightAnswer { get; set; }
}