using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class UserAnswerConfiguration : IEntityTypeConfiguration<UserAnswer>
{
    public void Configure(EntityTypeBuilder<UserAnswer> builder)
    {
        builder
            .HasOne(p => p.UserTest)
            .WithMany(p => p.UserAnswers)
            .HasForeignKey(k => k.UserTestId)
            .OnDelete(DeleteBehavior.NoAction);
        builder
            .HasOne(p => p.Question)
            .WithMany(p => p.UserAnswers)
            .HasForeignKey(k => k.QuestionId)
            .OnDelete(DeleteBehavior.NoAction);
        builder
            .HasOne(p => p.ChosenOption)
            .WithMany(p => p.UserAnswers)
            .HasForeignKey(k => k.ChosenOptionId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}