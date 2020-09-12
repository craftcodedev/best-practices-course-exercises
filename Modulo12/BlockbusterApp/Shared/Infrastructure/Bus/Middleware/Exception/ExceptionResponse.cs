using System;
using BlockbusterApp.src.Shared.Application.Bus.UseCase;

namespace BlockbusterApp.src.Shared.Infrastructure.Bus.Middleware.Exception
{
    public class ExceptionResponse : IResponse
    {
        public ExceptionResponse(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public string Code { get; }
        public string Message { get; }
    }
}
