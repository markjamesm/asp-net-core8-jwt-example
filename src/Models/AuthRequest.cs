namespace JwtRoleAuthentication.Models;

public class AuthRequest
{
    public string? Email { get; set; }
    public string? Password { get; set; }
}