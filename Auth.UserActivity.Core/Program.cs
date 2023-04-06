using Auth.UserActivity.Domain.Interfaces;
using Auth.UserActivity.Domain.Services;
using Auth.UserActivity.Infra.Context;
using Auth.UserActivity.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Auth.UserActivity.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                string connectionString = Settings._connectionString;
                services.AddDbContext<UserActivityContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

                services.AddScoped<IUserActivityService, UserActivityService>();
                services.AddScoped<IUserActivityRepository, UserActivityRepository>();
                services.AddScoped<IConsumeService, ConsumeService>();
                services.AddScoped(typeof(UserActivityContext));
            })
            .Build();

            using var serviceScope = host.Services.CreateScope();
            var serviceProvider = serviceScope.ServiceProvider;
            var consumeService = serviceProvider.GetRequiredService<IConsumeService>();
            consumeService.CheckQueue();
        }
    }
}