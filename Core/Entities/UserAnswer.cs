namespace Core.Entities;

public class UserAnswer
{
    public int Id { get; set; }
    
    public int UserTestId { get; set; }
    public UserTest UserTest { get; set; }
    
    public int QuestionId { get; set; }
    public Question Question { get; set; }
    
    public int ChosenOptionId { get; set; }
    public Option ChosenOption { get; set; }
}