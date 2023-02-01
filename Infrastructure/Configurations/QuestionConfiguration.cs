using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder
            .HasOne(p => p.Test)
            .WithMany(p => p.Questions)
            .HasForeignKey(k => k.TestId)
            .OnDelete(DeleteBehavior.NoAction);
        builder
            .HasMany(p => p.Options)
            .WithOne(p => p.Question)
            .HasForeignKey(k => k.QuestionId);
        builder
            .HasMany(p => p.UserAnswers)
            .WithOne(p => p.Question)
            .HasForeignKey(k => k.QuestionId);
    }
}