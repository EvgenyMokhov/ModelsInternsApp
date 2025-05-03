namespace Rabbit.Interns.Requests
{
    public class CreateInternRequest
    {
        public Guid TransactionId { get; set; }
        public InternDto RequestData { get; set; }
    }
}
