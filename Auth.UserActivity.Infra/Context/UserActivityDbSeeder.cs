using Auth.UserActivity.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth.UserActivity.Infra.Context
{
    public static class UserActivityDbSeeder
    {
        public static UserActivityModel _userActivity1 = new UserActivityModel
        {
            LastAccess = DateTime.Now.AddDays(-1),
            LastClientIP = "181.11.1.1",
            RegisteredOn = DateTime.Now.AddDays(-1),
            SessionExpire = DateTime.Now.AddDays(-1).AddHours(1),
            UserCompleteName = "Maicon Andrews",
            UserEmail = "maicon.andrew@mail.com",
            UserId = Guid.NewGuid().ToString(),
        };

        public static UserActivityModel _userActivity2 = new UserActivityModel
        {
            LastAccess = DateTime.Now.AddDays(-1),
            LastClientIP = "181.11.1.1",
            RegisteredOn = DateTime.Now.AddDays(-1),
            SessionExpire = DateTime.Now.AddDays(-1).AddHours(1),
            UserCompleteName = "Matthew Anderson",
            UserEmail = "matt.anderson@mail.com",
            UserId = Guid.NewGuid().ToString(),
        };

        public static void SeedInitialData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserActivityModel>()
            .HasData(
                _userActivity1,
                _userActivity2
            );
        }
    }
}
