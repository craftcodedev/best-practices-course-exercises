using BlockbusterApp.src.Shared.Domain.Event;

namespace BlockbusterApp.src.Shared.Infrastructure.Bus.Event
{
    public interface IDomainEventPublisher
    {
        void Publish(DomainEvent domainEvent);
    }
}
