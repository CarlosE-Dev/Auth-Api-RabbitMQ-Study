using Auth.Login.Domain.Interfaces;
using Auth.Login.Domain.Services;
using Auth.Login.Infra.Repositories;

namespace Auth.Login.Api.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IPublishService, PublishService>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
