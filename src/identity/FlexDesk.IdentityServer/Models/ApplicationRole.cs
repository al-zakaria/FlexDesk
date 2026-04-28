using Microsoft.AspNetCore.Identity;

namespace FlexDesk.IdentityServer.Models;

public class ApplicationRole : IdentityRole<Guid>
{
    public ApplicationRole() {}
    public ApplicationRole(string roleName) : base(roleName) {}
}