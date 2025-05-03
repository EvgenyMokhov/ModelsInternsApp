namespace Rabbit.Interns.Requests
{
    public class UpdateInternRequest
    {
        public Guid TransactionId { get; set; }
        public InternDto RequestData { get; set; }
    }
}
