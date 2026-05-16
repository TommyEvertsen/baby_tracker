namespace BabyTracker.Models;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string PasswordHash { get; set; } = string.Empty;
}