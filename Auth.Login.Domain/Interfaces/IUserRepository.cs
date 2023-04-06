using Auth.Login.Domain.Models;

namespace Auth.Login.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmail(string email);
    }
}
