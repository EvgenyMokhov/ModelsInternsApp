namespace Rabbit.Users.Requests
{
    public class UpdateUserRequest
    {
        public Guid TransactionId { get; set; }
        public UserDto RequestData { get; set; }
    }
}
