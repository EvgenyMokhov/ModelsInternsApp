namespace Rabbit.Projects.Requests
{
    public class UpdateProjectRequest
    {
        public Guid TransactionId { get; set; }
        public ProjectDto RequestData { get; set; }
    }
}
