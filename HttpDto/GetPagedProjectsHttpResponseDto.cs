namespace HttpDtos
{
    public class GetPagedProjectsHttpResponseDto
    {
        public List<ProjectHttpDto> Projects { get; set; }
        public int TotalCount { get; set; }
    }
}
