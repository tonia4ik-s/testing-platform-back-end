namespace Core.Entities;

public class Option
{
    public int Id { get; set; }
    public string OptionText { get; set; }
    public bool IsRightAnswer { get; set; }
    public int QuestionId { get; set; }
    public Question Question { get; set; }
    public ICollection<UserAnswer> UserAnswers { get; set; }
}