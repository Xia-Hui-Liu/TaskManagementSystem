using Microsoft.AspNetCore.Identity;

namespace TaskManagementServer.Models;

public class User:IdentityUser
{
    public string? UserId { get; set; }
    public string? Username { get; set; }
    public string Email { get; set; } 
    public string? Password { get; set; }

    // Navigation properties
    public ICollection<TaskCategory>? ListOfAssignment { get; set; }
}
