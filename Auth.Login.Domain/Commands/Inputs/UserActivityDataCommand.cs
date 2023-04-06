namespace Auth.Login.Domain.Commands.Inputs
{
    public class UserActivityDataCommand
    {
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserCompleteName { get; set; }
        public DateTime LastAccess { get; set; }
        public DateTime SessionExpire { get; set; }
        public string LastClientIP { get; set; }
    }
}
