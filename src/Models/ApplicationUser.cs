using JwtRoleAuthentication.Enums;
using Microsoft.AspNetCore.Identity;

namespace JwtRoleAuthentication.Models;

public class ApplicationUser : IdentityUser
{
    public Role Role { get; set; }
}