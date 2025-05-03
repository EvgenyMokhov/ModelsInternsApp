namespace HttpDtos
{
    public class InternHttpDto
    {
        public Guid Id { get; set; }
        public UserHttpDto User { get; set; }
        public ProjectLowDetailHttpDto Project { get; set; }
        public DirectionLowDetailHttpDto Direction { get; set; }
    }
}
