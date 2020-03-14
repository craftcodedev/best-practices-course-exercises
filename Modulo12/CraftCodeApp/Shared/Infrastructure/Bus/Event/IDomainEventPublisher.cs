using CraftCodeApp.src.Shared.Domain.Event;

namespace CraftCodeApp.src.Shared.Infrastructure.Bus.Event
{
    public interface IDomainEventPublisher
    {
        void Publish(DomainEvent domainEvent);
    }
}
