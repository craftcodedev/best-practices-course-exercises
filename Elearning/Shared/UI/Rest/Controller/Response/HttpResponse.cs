using elearning.Shared.Domain.Bus.Query;

namespace elearning.Shared.UI.Rest.Controller.Response
{
    public class HttpResponse : IResponse
    {
        public HttpResponse(int code, string message)
        {
            Code = code;
            Message = message;
        }

        public int Code { get; }
        public string Message { get; }
    }
}