namespace HttpDtos
{
    public class GetPagedDirectionsHttpResponseDto
    {
        public List<DirectionHttpDto> Directions { get; set; }
        public int TotalCount { get; set; }
    }
}
