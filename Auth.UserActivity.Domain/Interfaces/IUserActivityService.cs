using Auth.UserActivity.Domain.Models;

namespace Auth.UserActivity.Domain.Interfaces
{
    public interface IUserActivityService
    {
        void HandleUserActivityData(UserActivityModel model);
    }
}
