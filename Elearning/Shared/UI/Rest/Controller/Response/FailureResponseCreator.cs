using elearning.Shared.Domain.Exception;

namespace elearning.Shared.UI.Rest.Controller.Response
{
    public class FailureResponseCreator : IHttpResponseCreator
    {
        private System.Exception exception;

        public FailureResponseCreator(System.Exception exception)
        {
            this.exception = exception;
        }

        public HttpResponse Create()
        {
            int code = 500;

            if (exception is ValidationException)
            {
                code = 400;
            }

            return new HttpResponse(code, this.exception.Message);
        }
    }
}