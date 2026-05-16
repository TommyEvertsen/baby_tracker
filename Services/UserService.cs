using BabyTracker.Models;
using Microsoft.AspNetCore.Identity;

namespace BabyTracker.Services;

public class UserService
{
    private readonly PasswordHasher<User> _hasher = new();

    public string HashPassword(User user, string plainTextPassword)
    {
        return _hasher.HashPassword(user, plainTextPassword);
    }

    public bool VerifyPassword(User user, string plainTextPassword)
    {
        var result = _hasher.VerifyHashedPassword(user, user.PasswordHash, plainTextPassword);
        return result == PasswordVerificationResult.Success;
    }
}
