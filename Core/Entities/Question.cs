namespace Core.Entities;

public class Question
{
    public int Id { get; set; }
    public string QuestionText { get; set; }
    public float Mark { get; set; }
    public int TestId { get; set; }
    public Test Test { get; set; }
    public ICollection<Option> Options { get; set; }
    public ICollection<UserAnswer> UserAnswers { get; set; }
}
