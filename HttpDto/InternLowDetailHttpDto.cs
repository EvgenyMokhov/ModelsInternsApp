namespace HttpDtos
{
    public class InternLowDetailHttpDto
    {
        public Guid Id { get; set; }
        public UserHttpDto User { get; set; }
        public Guid ProjectId { get; set; }
        public Guid DirectionId { get; set; }
    }
}
