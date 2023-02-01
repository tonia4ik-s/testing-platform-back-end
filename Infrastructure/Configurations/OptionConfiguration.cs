using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class OptionConfiguration : IEntityTypeConfiguration<Option>
{
    public void Configure(EntityTypeBuilder<Option> builder)
    {
        builder
            .HasOne(p => p.Question)
            .WithMany(p => p.Options)
            .HasForeignKey(k => k.QuestionId);
        builder
            .HasMany(p => p.UserAnswers)
            .WithOne(p => p.ChosenOption)
            .HasForeignKey(k => k.ChosenOptionId);
    }
}