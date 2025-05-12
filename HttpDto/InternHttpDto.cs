namespace HttpDtos
{
    public class InternHttpDto
    {
        public Guid Id { get; set; }
        public UserHttpDto User { get; set; }
        public ProjectLowDetailHttpDto Project { get; set; }
        public DirectionLowDetailHttpDto Direction { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj is InternHttpDto intern)
            {
                return intern.Id == Id;
            }
            return false;
        }

        public override int GetHashCode() => Id.GetHashCode(); 
    }
}
