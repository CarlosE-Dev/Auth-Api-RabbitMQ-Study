namespace Auth.UserActivity.Domain.Interfaces
{
    public interface IConsumeService
    {
        void CheckQueue();
        void ReceiveMessage();
    }
}
