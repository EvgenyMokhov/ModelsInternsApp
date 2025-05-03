namespace Rabbit.Projects.Requests
{
    public class CreateProjectRequest
    {
        public Guid TransactionId { get; set; }
        public ProjectDto RequestData { get; set; }
    }
}
