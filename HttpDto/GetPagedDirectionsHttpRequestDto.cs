using Other.Enums;

namespace HttpDtos
{
    public class GetPagedDirectionsHttpRequestDto
    {
        public string DirectionsFilter { get; set; }
        public SortingParameter SortingParameter { get; set; }
        public int PageNumber { get; set; }
        public int DirectionsCountOnPage { get; set; }
    }
}
