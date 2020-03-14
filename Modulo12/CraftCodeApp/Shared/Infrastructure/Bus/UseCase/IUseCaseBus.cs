using System.Collections.Generic;
using CraftCodeApp.src.Shared.Application.Bus.UseCase;
using CraftCodeApp.src.Shared.Infrastructure.Bus.Middleware;

namespace CraftCodeApp.src.Shared.Infrastructure.Bus.UseCase
{
    public interface IUseCaseBus
    {
        void Subscribe(IUseCase useCase);
        IResponse Dispatch(IRequest req);
        void SetMiddlewares(List<IMiddlewareHandler> middlewareHanders);
    }
}
