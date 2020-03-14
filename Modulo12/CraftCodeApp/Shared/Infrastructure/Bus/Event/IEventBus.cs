using CraftCodeApp.src.Shared.Application.Bus.Event;
using CraftCodeApp.src.Shared.Domain.Event;

namespace CraftCodeApp.src.Shared.Infrastructure.Bus.Event
{
    public interface IEventBus
    {
        void Subscribe(IEventHandler eventHandler, string eventName);
        void Dispatch(DomainEvent domainEvent);
    }
}
