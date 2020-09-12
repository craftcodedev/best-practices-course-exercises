using System;
using BlockbusterApp.src.Shared.Application.Bus.UseCase;

namespace BlockbusterApp.src.Shared.Infrastructure.Bus.Middleware.Exception
{
    public class ExceptionConverter 
    {
        public ExceptionConverter()
        {
        }

        public IResponse Convert(string code, string message)
        {
            return new ExceptionResponse(code, message);
        }
    }
}
