using System;
using CraftCodeApp.src.Shared.Application.Bus.UseCase;

namespace CraftCodeApp.src.Shared.Infrastructure.Bus.Middleware
{
    public abstract class MiddlewareHandler : IMiddlewareHandler
    {
        private IMiddlewareHandler nextHandler;

        public IMiddlewareHandler SetNext(IMiddlewareHandler handler)
        {
            nextHandler = handler;
            return handler;
        }

        public virtual IResponse Handle(IRequest request)
        {
            return nextHandler.Handle(request);
        }
    }
}
