using Auth.Login.Domain.Commands.Inputs;
using Auth.Login.Domain.Commands.Outputs;

namespace Auth.Login.Domain.Interfaces
{
    public interface IAuthenticationService
    {
        Task<AuthenticateUserResponse> Authenticate(AuthenticateUserCommand command);
    }
}
