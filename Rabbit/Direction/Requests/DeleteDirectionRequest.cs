namespace Rabbit.Direction.Requests
{
    public class DeleteDirectionRequest
    {
        public Guid TransactionId { get; set; }
        public Guid Id { get; set; }
    }
}
