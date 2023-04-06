namespace Auth.Login.Domain.Models
{
    public class BaseModel
    {
        public string Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public BaseModel()
        {
            Id = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
            CreatedOn = DateTime.Now;
        }
    }
}
