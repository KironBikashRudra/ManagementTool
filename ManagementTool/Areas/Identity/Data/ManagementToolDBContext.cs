using ManagementTool.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ManagementTool.Areas.Identity.Data;

public class ManagementToolDBContext : IdentityDbContext<IdentityUser>
{
    public ManagementToolDBContext(DbContextOptions<ManagementToolDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }


    public DbSet<User> Users { get; set; }
    public DbSet<UserCredential> UserCredential { get; set; }
}
