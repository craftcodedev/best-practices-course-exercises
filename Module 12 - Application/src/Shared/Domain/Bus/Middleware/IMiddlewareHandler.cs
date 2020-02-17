using App.Shared.Domain.Bus.UseCase;
using System;

namespace App.Shared.Domain.Bus.Middleware
{
    public interface IMiddlewareHandler
    {
        IMiddlewareHandler SetNext(IMiddlewareHandler handler);
        
        IResponse Handle(IRequest request);
    }
}