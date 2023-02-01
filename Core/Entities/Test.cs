namespace Core.Entities;

public class Test
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public float MaxResult { get; set; }
    public ICollection<Question> Questions { get; set; }
    public ICollection<UserTest> UserTests { get; set; }
}
