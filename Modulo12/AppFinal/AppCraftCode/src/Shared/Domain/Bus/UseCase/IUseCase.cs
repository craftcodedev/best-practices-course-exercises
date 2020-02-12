using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Shared.Domain.Bus.UseCase
{
    public interface IUseCase
    {
        IResponse Execute(IRequest req);
    }
}
