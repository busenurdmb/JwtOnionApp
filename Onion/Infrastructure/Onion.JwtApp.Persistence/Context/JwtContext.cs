using Microsoft.EntityFrameworkCore;
using Onion.JwtApp.Domain.Entities;
using Onion.JwtApp.Persistence.Configurations;

namespace Onion.JwtApp.Persistence.Context
{
    public class JwtContext : DbContext
    {
        public JwtContext(DbContextOptions<JwtContext> options) : base(options)
        {

        }
        public DbSet<AppRole>? AppRoles { get; set; }
        public DbSet<AppUser>? AppUsers { get; set; }
        public DbSet<Category>? Category { get; set; }
        public DbSet<Product>? Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
