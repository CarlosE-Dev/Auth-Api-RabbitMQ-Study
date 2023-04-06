using Auth.Login.Domain.Commands.Inputs;
using Auth.Login.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Login.Api.Controllers
{
    [ApiController]
    [Route("login")]
    public class LoginController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LoginController(IAuthenticationService authenticationService, IHttpContextAccessor httpContextAccessor)
        {
            _authenticationService = authenticationService;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost("login", Name = "Authenticate")]
        [Produces(typeof(string))]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateUserCommand command)
        {
            try
            {
                command.UserIp = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress?.ToString();
                return Ok(await _authenticationService.Authenticate(command));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
