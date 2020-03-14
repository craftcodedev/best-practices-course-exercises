using CraftCodeApp.src.Shared.Domain.Event;

namespace CraftCodeApp.src.Shared.Application.Bus.Event
{
    public interface IEventHandler
    {
        void Handle(DomainEvent domainEvent);
    }
}
