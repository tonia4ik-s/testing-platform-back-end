namespace Core.Entities;

public class UserTest
{
    public int Id { get; set; }
    public string AssignedToId { get; set; }
    public User AssignedTo { get; set; }
    
    public int TestId { get; set; }
    public Test Test { get; set; }
    
    public bool IsFinished { get; set; }
    public float Result { get; set; }
    public ICollection<UserAnswer> UserAnswers { get; set; }
}