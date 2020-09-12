using System.Collections.Generic;
using BlockbusterApp.src.Shared.Application.Bus.UseCase;
using BlockbusterApp.src.Shared.Infrastructure.Bus.Middleware;

namespace BlockbusterApp.src.Shared.Infrastructure.Bus.UseCase
{
    public interface IUseCaseBus
    {
        void Subscribe(IUseCase useCase);
        IResponse Dispatch(IRequest req);
        void SetMiddlewares(List<IMiddlewareHandler> middlewareHanders);
    }
}
