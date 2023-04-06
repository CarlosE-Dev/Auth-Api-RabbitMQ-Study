using Auth.UserActivity.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth.UserActivity.Infra.Context
{
    public class UserActivityContext : DbContext
    {
        public UserActivityContext(DbContextOptions<UserActivityContext> options) : base(options) { }

        public DbSet<UserActivityModel> UserActivities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserActivityContext).Assembly);

            UserActivityDbSeeder.SeedInitialData(modelBuilder);
        }
    }
}
