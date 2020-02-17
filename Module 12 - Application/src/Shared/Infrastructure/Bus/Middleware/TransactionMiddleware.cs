using App.Shared.Domain.Bus.Middleware;
using App.Shared.Domain.Bus.UseCase;
using System;

namespace App.Shared.Infrastructure.Bus.Middleware
{
    public class TransactionMiddleware : MiddlewareHandler
    {
        public override IResponse Handle(IRequest request)
        {
            System.Console.WriteLine("TransactionMiddleware");
            return base.Handle(request);
        }
    }
}