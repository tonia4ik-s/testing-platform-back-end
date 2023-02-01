using Bogus;
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public static class Seed
{
    private static readonly PasswordHasher<User> PasswordHasher = new();

    public static void SeedData(this ModelBuilder builder)
    {
        SeedUser(builder);
        SeedTest(builder);
        SeedQuestion(builder);
        SeedOption(builder);
        SeedUserTest(builder);
        SeedUserAnswers(builder);
    }

    #region User

    private static readonly string User0Id = Guid.NewGuid().ToString();
    private static readonly string User1Id = Guid.NewGuid().ToString();
    private static readonly string User2Id = Guid.NewGuid().ToString();
    private static readonly string User3Id = Guid.NewGuid().ToString();
    private static readonly string ToniaId = Guid.NewGuid().ToString();

    private static void SeedUser(ModelBuilder builder)
    {
        var persons = new List<Person>();
        for (var i = 0; i < 4; i++)
        {
            persons.Add(new Person());
        }

        var user0 = new User
        {
            Id = User0Id,
            UserName = persons[0].UserName,
            NormalizedEmail = persons[0].Email.ToUpper(),
            NormalizedUserName = persons[0].UserName.ToUpper(),
            Email = persons[0].Email
        };
        var user1 = new User
        {
            Id = User1Id,
            UserName = persons[1].UserName,
            NormalizedEmail = persons[1].Email.ToUpper(),
            NormalizedUserName = persons[1].UserName.ToUpper(),
            Email = persons[1].Email
        };
        var user2 = new User
        {
            Id = User2Id,
            UserName = persons[2].UserName,
            NormalizedEmail = persons[2].Email.ToUpper(),
            NormalizedUserName = persons[2].UserName.ToUpper(),
            Email = persons[2].Email
        };
        var user3 = new User
        {
            Id = User3Id,
            UserName = persons[3].UserName,
            NormalizedEmail = persons[3].Email.ToUpper(),
            NormalizedUserName = persons[3].UserName.ToUpper(),
            Email = persons[3].Email
        };
        var userTonia = new User
        {
            Id = ToniaId,
            UserName = "ton4ik",
            NormalizedEmail = "antonina.loboda@oa.edu.ua".ToUpper(),
            NormalizedUserName = "ton4ik".ToUpper(),
            Email = "antonina.loboda@oa.edu.ua"
        };
        user0.PasswordHash = PasswordHasher.HashPassword(user0, "Password_1");
        user1.PasswordHash = PasswordHasher.HashPassword(user1, "Password_1");
        user2.PasswordHash = PasswordHasher.HashPassword(user2, "Password_1");
        user3.PasswordHash = PasswordHasher.HashPassword(user3, "Password_1");
        userTonia.PasswordHash = PasswordHasher.HashPassword(userTonia, "Password_1");
        builder.Entity<User>().HasData(userTonia, user0, user1, user2, user3);
    }

    #endregion

    #region Test

    private static void SeedTest(ModelBuilder builder)
    {
        var test1 = new Test
        {
            Id = 1,
            Title = "Multi-quiz",
            Description = "Show your knowledge in different topics! Good luck!",
            MaxResult = 10
        };
        builder.Entity<Test>().HasData(test1);
    }

    #endregion

    #region Questions
    
    private static void SeedQuestion(ModelBuilder builder)
    {
        var question1 = new Question
        {
            Id = 1,
            TestId = 1,
            QuestionText = "The capital of Ukraine is...",
            Mark = 2
        };
        var question2 = new Question
        {
            Id = 2,
            TestId = 1,
            QuestionText = "3 + 3 * 3 = ...",
            Mark = 2
        };
        var question3 = new Question
        {
            Id = 3,
            TestId = 1,
            QuestionText = "Which color will be, if mix blue and yellow?",
            Mark = 2
        };
        var question4 = new Question
        {
            Id = 4,
            TestId = 1,
            QuestionText = "Tanya is older than Eric." +
                           "\nCliff is older than Tanya." +
                           "\nEric is older than Cliff." +
                           "\nIf the first two statements are true, the third statement is",
            Mark = 2
        };
        var question5 = new Question
        {
            Id = 5,
            TestId = 1,
            QuestionText = "How many elements are in the periodic table?",
            Mark = 2
        };
        builder.Entity<Question>().HasData(question1, question2, question3, question4, question5);
    }
    
    #endregion

    #region Options

    private static void SeedOption(ModelBuilder builder)
    {
        Option opt1 = new()
        {
            Id = 1,
            QuestionId = 1,
            OptionText = "Lviv",
            IsRightAnswer = false
        };
        Option opt2 = new()
        {
            Id = 2,
            QuestionId = 1,
            OptionText = "Kharkiv",
            IsRightAnswer = false
        };
        Option opt3 = new()
        {
            Id = 3,
            QuestionId = 1,
            OptionText = "Kyiv",
            IsRightAnswer = true
        };
        Option opt4 = new()
        {
            Id = 4,
            QuestionId = 1,
            OptionText = "Chernigiv",
            IsRightAnswer = false
        };
        Option opt5 = new()
        {
            Id = 5,
            QuestionId = 2,
            OptionText = "18",
            IsRightAnswer = false
        };
        Option opt6 = new()
        {
            Id = 6,
            QuestionId = 2,
            OptionText = "9",
            IsRightAnswer = false
        };
        Option opt7 = new()
        {
            Id = 7,
            QuestionId = 2,
            OptionText = "12",
            IsRightAnswer = true
        };
        Option opt8 = new()
        {
            Id = 8,
            QuestionId = 2,
            OptionText = "27",
            IsRightAnswer = false
        };
        Option opt9 = new()
        {
            Id = 9,
            QuestionId = 3,
            OptionText = "green",
            IsRightAnswer = true
        };
        Option opt10 = new()
        {
            Id = 10,
            QuestionId = 3,
            OptionText = "blue",
            IsRightAnswer = false
        };
        Option opt11 = new()
        {
            Id = 11,
            QuestionId = 3,
            OptionText = "pink",
            IsRightAnswer = false
        };
        Option opt12 = new()
        {
            Id = 12,
            QuestionId = 3,
            OptionText = "purple",
            IsRightAnswer = false
        };
        Option opt13 = new()
        {
            Id = 13,
            QuestionId = 4,
            OptionText = "true",
            IsRightAnswer = false
        };
        Option opt14 = new()
        {
            Id = 14,
            QuestionId = 4,
            OptionText = "false",
            IsRightAnswer = true
        };
        Option opt15 = new()
        {
            Id = 15,
            QuestionId = 4,
            OptionText = "uncertain",
            IsRightAnswer = false
        };
        Option opt16 = new()
        {
            Id = 16,
            QuestionId = 5,
            OptionText = "100",
            IsRightAnswer = false
        };
        Option opt17 = new()
        {
            Id = 17,
            QuestionId = 5,
            OptionText = "30",
            IsRightAnswer = false
        };
        Option opt18 = new()
        {
            Id = 18,
            QuestionId = 5,
            OptionText = "118",
            IsRightAnswer = true
        };

        builder.Entity<Option>().HasData(
            opt1, opt2, opt3, opt4,
            opt5, opt6, opt7, opt8,
            opt9, opt10, opt11, opt12,
            opt13, opt14, opt15,
            opt16, opt17, opt18);
    }

    #endregion

    #region UserTest

    private static void SeedUserTest(ModelBuilder builder)
    {
        var userTest1 = new UserTest
        {
            Id = 1,
            AssignedToId = User0Id,
            TestId = 1,
            IsFinished = false
        };
        var userTest2 = new UserTest
        {
            Id = 2,
            AssignedToId = User1Id,
            TestId = 1,
            IsFinished = false
        };
        var userTest3 = new UserTest
        {
            Id = 3,
            AssignedToId = ToniaId,
            TestId = 1,
            IsFinished = true,
            Result = 10
        };
        builder.Entity<UserTest>().HasData(userTest1, userTest2, userTest3);
    }

    #endregion

    #region UserAnswers

    private static void SeedUserAnswers(ModelBuilder builder)
    {
        var userAnswer1 = new UserAnswer
        {
            Id = 1,
            QuestionId = 1,
            UserTestId = 3,
            ChosenOptionId = 3
        };
        var userAnswer2 = new UserAnswer
        {
            Id = 2,
            QuestionId = 2,
            UserTestId = 3,
            ChosenOptionId = 7
        };
        var userAnswer3 = new UserAnswer
        {
            Id = 3,
            QuestionId = 3,
            UserTestId = 3,
            ChosenOptionId = 9
        };
        var userAnswer4 = new UserAnswer
        {
            Id = 4,
            QuestionId = 4,
            UserTestId = 3,
            ChosenOptionId = 14
        };
        var userAnswer5 = new UserAnswer
        {
            Id = 5,
            QuestionId = 5,
            UserTestId = 3,
            ChosenOptionId = 18
        };
        builder.Entity<UserAnswer>()
            .HasData(userAnswer1, userAnswer2, userAnswer3, userAnswer4, userAnswer5);
    }

    #endregion

    // #region Roles
    //
    // private static readonly string Role1Id = Guid.NewGuid().ToString();
    // private static readonly string Role2Id = Guid.NewGuid().ToString();
    //
    // private static void SeedRoles(ModelBuilder builder)
    // {
    //     builder.Entity<Role>().HasData(
    //         new Role
    //         {
    //             Id = Role1Id,
    //             Name = "Admin",
    //             NormalizedName = "ADMIN"
    //         }, 
    //         new Role
    //         {
    //             Id = Role2Id,
    //             Name = "User",
    //             NormalizedName = "USER"
    //         });
    // }
    //
    // #endregion
    //
    // #region UserRoles
    //
    // private static void SeedUserRole(ModelBuilder builder)
    // {
    //     builder.Entity<UserRole>()
    // }
    //
    // #endregion
}
