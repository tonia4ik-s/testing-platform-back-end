using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasMany(p => p.UserTests)
            .WithOne(p => p.AssignedTo)
            .HasForeignKey(k => k.AssignedToId);
        builder
            .HasMany(p => p.RefreshTokens)
            .WithOne(p => p.User)
            .HasForeignKey(k => k.UserId);
    }
}
