using System.Net;

namespace Client.Exceptions
{
    public class PrintfulClientException: Exception
    {
        
        public HttpStatusCode StatusCode { get; set; }
        public string Method { get; set; }

        public PrintfulClientException(string method, HttpStatusCode statusCode, string message)
            : base($"An error occured when attempting {method}. Status code:{statusCode}. Exception details: {message}")
        {
            StatusCode = statusCode;
            Method = method;
        }
    }
}