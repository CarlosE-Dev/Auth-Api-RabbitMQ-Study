namespace Auth.UserActivity.Domain.Models
{
    public class UserActivityModel
    {
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserCompleteName { get; set; }
        public DateTime LastAccess { get; set; }
        public DateTime SessionExpire { get; set; }
        public string LastClientIP { get; set; }
        public DateTime RegisteredOn { get; set; }
    }
}
