namespace Rabbit.Direction.Requests
{
    public class CreateDirectionRequest
    {
        public Guid TransactionId { get; set; }
        public DirectionDto RequestData { get; set; }
    }
}
