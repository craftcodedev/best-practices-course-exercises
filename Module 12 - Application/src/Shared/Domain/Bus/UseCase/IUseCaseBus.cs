using App.Shared.Domain.Bus.Middleware;
using System.Collections.Generic;

namespace App.Shared.Domain.Bus.UseCase
{
    public interface IUseCaseBus
    {
        void Subscribe(IUseCase useCase);

        void SetMiddlewares(List<IMiddlewareHandler> middlewareHanders);

        IResponse Dispatch(IRequest request);
    }
}