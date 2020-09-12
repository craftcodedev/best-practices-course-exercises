using System;
namespace BlockbusterApp.src.Shared.Application.Bus.UseCase
{
    public interface IUseCase
    {
        IResponse Execute(IRequest req);
    }
}
