namespace Rabbit.Interns.Requests
{
    public class GetInternsByDirectionRequest
    {
        public Guid TransactionId { get; set; }
        public Guid DirectionId { get; set; }
    }
}
