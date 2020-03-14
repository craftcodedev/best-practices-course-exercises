using System;
using CraftCodeApp.src.Shared.Application.Bus.UseCase;

namespace CraftCodeApp.src.Shared.Infrastructure.Bus.Middleware
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
            return useCase.Execute(request);
        }
    }
}
