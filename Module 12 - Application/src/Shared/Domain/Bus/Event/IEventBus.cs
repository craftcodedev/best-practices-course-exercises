using App.Shared.Domain;

namespace App.Shared.Domain.Bus.Event
{
    public interface IEventBus
    {
        void Subscribe(IEventHandler eventHandler, string eventName);

        void Dispatch(DomainEvent domainEvent);
    }
}