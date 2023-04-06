using Auth.UserActivity.Domain.Interfaces;
using Auth.UserActivity.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Auth.UserActivity.Domain.Services
{
    public class UserActivityService : IUserActivityService
    {
        private readonly IServiceProvider _serviceProvider;
        public UserActivityService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void HandleUserActivityData(UserActivityModel model)
        {
            if (model != null)
            {
                model.RegisteredOn = DateTime.Now;

                using var scope = _serviceProvider.CreateScope();
                var service = scope.ServiceProvider.GetRequiredService<IUserActivityRepository>();
                service.PersistUserActivityData(model);
            }
        }
    }
}
