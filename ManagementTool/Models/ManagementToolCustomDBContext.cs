namespace ManagementTool.Models
{
    using ManagementTool.Areas.Identity.Data;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;

    public class ManagementToolCustomDBContext : DbContext
    {

        public ManagementToolCustomDBContext(DbContextOptions<ManagementToolCustomDBContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserCredential> UserCredential { get; set; }
    }
}
