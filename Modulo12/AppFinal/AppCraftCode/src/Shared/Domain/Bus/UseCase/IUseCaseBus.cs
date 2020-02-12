using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Shared.Domain.Bus.UseCase
{
    public interface IUseCaseBus
    {
        void Subscribe(IUseCase useCase);

        IResponse Dispatch(IRequest request);
    }
}
