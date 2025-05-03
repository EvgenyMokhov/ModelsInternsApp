namespace HttpDtos
{
    public class ProjectHttpDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public List<InternLowDetailHttpDto> Interns { get; set; }
    }
}
