using System;
using CraftCodeApp.src.Shared.Application.Bus.UseCase;

namespace CraftCodeApp.src.Shared.Infrastructure.Bus.Middleware
{
    public interface IMiddlewareHandler
    {
        IMiddlewareHandler SetNext(IMiddlewareHandler handler);
        IResponse Handle(IRequest request);
    }
}
