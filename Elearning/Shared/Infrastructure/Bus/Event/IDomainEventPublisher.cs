using elearning.Shared.Domain.Bus.Event;

namespace elearning.Shared.Infrastructure.Bus.Event
{
    public interface IDomainEventPublisher
    {
        void Publish(DomainEvent domainEvent);
    }
}