namespace Rabbit.Direction.Requests
{
    public class UpdateDirectionRequest
    {
        public Guid TransactionId { get; set; }
        public DirectionDto RequestData { get; set; }
    }
}
