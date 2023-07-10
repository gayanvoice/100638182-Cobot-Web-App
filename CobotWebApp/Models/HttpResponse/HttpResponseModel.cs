using System.Net;

namespace CobotWebApp.Models.HttpResponse
{
    public class HttpResponseModel
    {
        public int HttpStatusCode { get; set; }
        public string? Message { get; set; }
        public double Duration { get; set; }
        public object? Exception { get; set; }
    }
}