using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RolesAuth.Models;

namespace RolesAuth.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
