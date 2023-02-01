using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class UserTestConfiguration : IEntityTypeConfiguration<UserTest>
{
    public void Configure(EntityTypeBuilder<UserTest> builder)
    {
        builder
            .HasOne(p => p.Test)
            .WithMany(p => p.UserTests)
            .HasForeignKey(k => k.TestId);
        builder
            .HasOne(p => p.AssignedTo)
            .WithMany(p => p.UserTests)
            .HasForeignKey(k => k.AssignedToId);
        builder
            .HasMany(p => p.UserAnswers)
            .WithOne(p => p.UserTest)
            .HasForeignKey(k => k.UserTestId);
    }
}
