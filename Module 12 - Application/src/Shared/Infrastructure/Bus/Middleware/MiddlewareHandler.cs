using App.Shared.Domain.Bus.Middleware;
using App.Shared.Domain.Bus.UseCase;
using System;

namespace App.Shared.Infrastructure.Bus.Middleware
{
    public abstract class MiddlewareHandler : IMiddlewareHandler
    {
        private IMiddlewareHandler nextHandler;

        public IMiddlewareHandler SetNext(IMiddlewareHandler handler)
        {
            this.nextHandler = handler;
            
            return handler;
        }
        
        public virtual IResponse Handle(IRequest request)
        {
            //if (this.nextHandler != null)
            //{
                return this.nextHandler.Handle(request);
            //}
        }
    }
}