using BlockbusterApp.src.Shared.Application.Bus.Event;
using BlockbusterApp.src.Shared.Domain.Event;

namespace BlockbusterApp.src.Shared.Infrastructure.Bus.Event
{
    public interface IEventBus
    {
        void Subscribe(IEventHandler eventHandler, string eventName);
        void Dispatch(DomainEvent domainEvent);
    }
}
