namespace App.Shared.Domain.Bus.UseCase
{
    public interface IUseCase
    {
        IResponse Execute(IRequest req);
    }
}