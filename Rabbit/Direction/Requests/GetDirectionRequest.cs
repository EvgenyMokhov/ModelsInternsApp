namespace Rabbit.Direction.Requests
{
    public class GetDirectionRequest
    {
        public Guid TransactionId { get; set; }
        public Guid Id { get; set; }
    }
}
