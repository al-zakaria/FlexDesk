using Microsoft.AspNetCore.Identity;

namespace FlexDesk.IdentityServer.Models;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public DateTime DateOfRegistration { get; set; }
    
    public string? AvatarUrl { get; set; }
}