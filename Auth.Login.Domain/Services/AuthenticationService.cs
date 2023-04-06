using Auth.Login.Domain.Commands.Inputs;
using Auth.Login.Domain.Commands.Outputs;
using Auth.Login.Domain.Interfaces;
using Auth.Login.Domain.Models;

namespace Auth.Login.Domain.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IPublishService _publishService;
        private readonly IUserRepository _userRepository;
        public AuthenticationService(IPublishService publishService, IUserRepository userRepository)
        {
            _publishService = publishService;
            _userRepository = userRepository;
        }
        public async Task<AuthenticateUserResponse> Authenticate(AuthenticateUserCommand command)
        {
            var user = await GetUserByEmail(command.Email);
            if (user == null) throw new Exception("Invalid E-mail");

            if (command.Password != user.Password) throw new Exception("Invalid Password");

            var userToPublish = new UserActivityDataCommand 
            { 
                UserId = user.Id,
                UserEmail = user.Email,
                UserCompleteName = user.FirstName + " " + user.LastName, 
                LastAccess = DateTime.Now,
                SessionExpire = DateTime.Now.AddHours(1),
                LastClientIP = command.UserIp 
            };

            _publishService.Publish(userToPublish);

            return new AuthenticateUserResponse(user.Id, user.Email, user.FirstName + "" + user.LastName);
        }

        private async Task<User> GetUserByEmail(string email)
        {
            return await _userRepository.GetUserByEmail(email);
        }
    }
}
