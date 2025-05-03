namespace Rabbit.Interns.Requests
{
    public class GetInternsByProjectRequest
    {
        public Guid TransactionId { get; set; }
        public Guid ProjectId { get; set; }
    }
}
