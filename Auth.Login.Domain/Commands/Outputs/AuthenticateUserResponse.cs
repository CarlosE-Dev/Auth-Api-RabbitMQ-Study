namespace Auth.Login.Domain.Commands.Outputs
{
    public class AuthenticateUserResponse
    {
        public string UserId { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }

        public AuthenticateUserResponse(string userId, string login, string name)
        {
            UserId = userId;
            Login = login;
            Name = name;
        }
    }
}
