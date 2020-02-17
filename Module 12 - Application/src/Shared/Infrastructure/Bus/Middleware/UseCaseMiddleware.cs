using App.Shared.Domain.Bus.Middleware;
using App.Shared.Domain.Bus.UseCase;
using System;

namespace App.Shared.Infrastructure.Bus.Middleware
{
    public class UseCaseMiddleware : MiddlewareHandler
    {
        private IUseCase useCase;
        
        public UseCaseMiddleware(IUseCase useCase)
        {
            this.useCase = useCase;
        }
        public override IResponse Handle(IRequest request)
        {
            System.Console.WriteLine("UseCaseMiddleware");

            return this.useCase.Execute(request);
            //return base.Handle(request);
        }
    }
}