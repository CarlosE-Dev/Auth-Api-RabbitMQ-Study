using Auth.UserActivity.Domain.Models;

namespace Auth.UserActivity.Domain.Interfaces
{
    public interface IUserActivityRepository
    {
        void PersistUserActivityData(UserActivityModel model);
    }
}
