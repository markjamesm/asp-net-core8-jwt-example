using JwtRoleAuthentication.Enums;
using JwtRoleAuthentication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JwtRoleAuthentication.Data;

public class ApplicationDbContext : IdentityUserContext<ApplicationUser>
{
    public DbSet<Page> Pages => Set<Page>();
    
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}