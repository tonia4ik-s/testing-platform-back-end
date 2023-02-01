using Microsoft.AspNetCore.Identity;

namespace Core.Entities;

public class User : IdentityUser
{
    public ICollection<UserTest> UserTests { get; set; }
    public ICollection<RefreshToken> RefreshTokens { get; set; }
}
