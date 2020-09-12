using BlockbusterApp.src.Shared.Domain.Event;

namespace BlockbusterApp.src.Shared.Application.Bus.Event
{
    public interface IEventHandler
    {
        void Handle(DomainEvent domainEvent);
    }
}
