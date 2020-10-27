namespace Handyman.Service.Handler.Common
{
    public class HttpBaseResponse
    {
        public string Title { get; set; }
        public int Status { get; set; }
        public ErrorDetail ErrorDetails { get; set; }
    }
    public class ErrorDetail
    {
        public string Detail { get; set; }
    }
}
