using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Auth.Login.Domain.Commands.Inputs
{
    public class AuthenticateUserCommand
    {
        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "The length of the field {0} must be {2} to {1} characters", MinimumLength = 5)]
        public string Email { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The length of the field {0} must be {2} to {1} characters", MinimumLength = 6)]
        public string Password { get; set; }

        [JsonIgnore]
        [StringLength(30, ErrorMessage = "The length of the field {0} must be {2} to {1} characters", MinimumLength = 5)]
        public string UserIp { get; set; }

        public AuthenticateUserCommand(string email, string password, string userIp = null)
        {
            Email = email;
            Password = password;
            UserIp = userIp;
        }
    }
}
