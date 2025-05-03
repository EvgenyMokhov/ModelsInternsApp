namespace Rabbit.Users.Requests
{
    public class CreateUserRequest
    {
        public Guid TransactionId { get; set; }
        public UserDto RequestData { get; set; }
    }
}
