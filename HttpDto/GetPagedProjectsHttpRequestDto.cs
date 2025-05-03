using Other.Enums;

namespace HttpDtos
{
    public class GetPagedProjectsHttpRequestDto
    {
        public string ProjectsFilter { get; set; }
        public SortingParameter SortingParameter { get; set; }
        public int PageNumber { get; set; }
        public int ProjectCountOnPage { get; set; }
    }
}
