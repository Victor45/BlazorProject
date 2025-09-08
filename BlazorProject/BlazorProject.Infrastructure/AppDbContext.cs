using BlazorProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Infrastructure
{
     public class AppDbContext : DbContext
     {
          public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

          public DbSet<User> Users { get; set; }
     }
}
