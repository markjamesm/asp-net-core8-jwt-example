using System.ComponentModel.DataAnnotations;
using JwtRoleAuthentication.Enums;

namespace JwtRoleAuthentication.Models;

public class RegistrationRequest
{
    [Required]
    public string Email { get; set; } = null!;
    
    [Required]
    public string Username { get; set; } = null!;
    
    [Required]
    public string Password { get; set; } = null!;

    public Role Role { get; set; } = Role.User;
}