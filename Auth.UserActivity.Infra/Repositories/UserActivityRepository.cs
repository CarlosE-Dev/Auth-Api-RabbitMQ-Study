using Auth.UserActivity.Domain.Interfaces;
using Auth.UserActivity.Domain.Models;
using Auth.UserActivity.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Auth.UserActivity.Infra.Repositories
{
    public class UserActivityRepository : IUserActivityRepository
    {
        private readonly IServiceProvider _serviceProvider;
        public UserActivityRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async void PersistUserActivityData(UserActivityModel model)
        {
            using var scope = _serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<UserActivityContext>();
            var activity = await GetUserActivity(model.UserId, context);

            if (activity != null)
            {
                context.Set<UserActivityModel>().Update(model);
                await context.SaveChangesAsync();
            }

            if(activity == null)
            {
                context.Set<UserActivityModel>().Add(model);
                await context.SaveChangesAsync();
            }
        }

        public async Task<UserActivityModel> GetUserActivity(string id, UserActivityContext context)
        {
            return await context.Set<UserActivityModel>().AsNoTracking().FirstOrDefaultAsync(x => x.UserId == id);
        }
    }
}
