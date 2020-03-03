namespace OnsiteSewageFacilitiesInspectionApiClient.Models
{
    // Schema aims to follow API standard guidelines
    // https://api.gov.au/standards/national_api_standards/error-handling.html
    public class ApiResponseContent
    {
        public ApiResponseContentError[] Errors { get; set; }
    }

    public class ApiResponseContentError
    {
        public string Detail { get; set; }
        public string Code { get; set; }
    }
}
