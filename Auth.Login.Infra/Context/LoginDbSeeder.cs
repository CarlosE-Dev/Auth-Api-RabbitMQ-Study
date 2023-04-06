using Auth.Login.Domain.Models;
using Auth.Login.Domain.Utils;
using Microsoft.EntityFrameworkCore;

namespace Auth.Login.Infra.Context
{
    public class LoginDbSeeder
    {
        public static User UserTest = new User
        {
            Id = Guid.NewGuid().ToString(),
            CreatedOn = DateTime.Now,
            Email = "test@test.com",
            FirstName = "James",
            LastName = "Young",
            Password = "test123"
        };
        public static User User1 = new User
        {
            Id = Guid.NewGuid().ToString(),
            CreatedOn = DateTime.Now,
            Email = GenerateString.RandomStringAlpha(5) + "@" + GenerateString.RandomStringAlpha(5) + ".com",
            FirstName = GenerateString.RandomStringAlpha(5),
            LastName = GenerateString.RandomStringAlpha(5),
            Password = GenerateString.RandomStringAlpha(8) 
        };
        public static User User2 = new User
        {
            Id = Guid.NewGuid().ToString(),
            CreatedOn = DateTime.Now,
            Email = GenerateString.RandomStringAlpha(5) + "@" + GenerateString.RandomStringAlpha(5) + ".com",
            FirstName = GenerateString.RandomStringAlpha(5),
            LastName = GenerateString.RandomStringAlpha(5),
            Password = GenerateString.RandomStringAlpha(8)
        };
        public static User User3 = new User
        {
            Id = Guid.NewGuid().ToString(),
            CreatedOn = DateTime.Now,
            Email = GenerateString.RandomStringAlpha(5) + "@" + GenerateString.RandomStringAlpha(5) + ".com",
            FirstName = GenerateString.RandomStringAlpha(5),
            LastName = GenerateString.RandomStringAlpha(5),
            Password = GenerateString.RandomStringAlpha(8)
        };

        public static void SeedInitialData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                    UserTest,
                    User1,
                    User2,
                    User3
                );
        }
    }
}
