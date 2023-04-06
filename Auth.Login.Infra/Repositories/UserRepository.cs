using Auth.Login.Domain.Interfaces;
using Auth.Login.Domain.Models;
using Auth.Login.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Auth.Login.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LoginContext _context;
        public UserRepository(LoginContext context)
        {
            _context = context;
        }
        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Set<User>().AsNoTracking().FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
