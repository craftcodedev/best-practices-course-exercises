using System;
using CraftCodeApp.src.Shared.Application.Bus.UseCase;
using CraftCodeApp.src.Shared.Domain.Exception;
using CraftCodeApp.src.Shared.Infrastructure.Bus.Middleware.Exception;

namespace CraftCodeApp.src.Shared.Infrastructure.Bus.Middleware
{
    public class ExceptionMiddleware : MiddlewareHandler
    {
        private ExceptionConverter _converter;

        public ExceptionMiddleware(ExceptionConverter converter)
        {
            _converter = converter;
        }

        public override IResponse Handle(IRequest request)
        {
            try
            {
                IResponse response = base.Handle(request);
                return response;
            }
            catch(ValidationException validation)
            {
                return _converter.Convert("400", validation.Message);
            }
            catch (System.Exception exc)
            {
                throw exc;
                return _converter.Convert("500", exc.Message);
            }

        }
    }
}
