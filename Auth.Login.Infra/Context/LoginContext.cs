using Auth.Login.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth.Login.Infra.Context
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LoginContext).Assembly);

            LoginDbSeeder.SeedInitialData(modelBuilder);
        }
    }
}