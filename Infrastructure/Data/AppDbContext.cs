using System.Reflection;
using Core.Entities;
using Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) {}
    public DbSet<Test> Tests { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Option> Options { get; set; }
    public DbSet<UserTest> UserTests { get; set; }
    public DbSet<UserAnswer> UserAnswers { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.SeedData();
        builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(UserConfiguration))!);
        base.OnModelCreating(builder);
    }
}