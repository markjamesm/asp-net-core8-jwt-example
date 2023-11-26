namespace JwtRoleAuthentication.Models;

public class PageDto
{
    public required int Id { get; set; }
    public required string? Title { get; set; }
    public required string? Body { get; set; }
    public required string? Author { get; set; }
}