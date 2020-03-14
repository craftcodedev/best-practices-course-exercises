using System;
using CraftCodeApp.src.Shared.Application.Bus.UseCase;

namespace CraftCodeApp.src.Shared.Infrastructure.Bus.Middleware.Exception
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
