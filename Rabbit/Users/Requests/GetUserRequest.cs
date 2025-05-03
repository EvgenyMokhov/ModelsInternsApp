namespace Rabbit.Users.Requests
{
    public class GetUserRequest
    {
        public Guid TransactionId { get; set; }
        public Guid UserId { get; set; }
    }
}
