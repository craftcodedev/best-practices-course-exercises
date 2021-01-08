using elearning.Shared.Domain.Bus.Event;

namespace elearning.Shared.Infrastructure.Bus.Event
{
    public class DomainEventPublisherSync : IDomainEventPublisher
    {
        private readonly IEventBus eventBus;

        public DomainEventPublisherSync(IEventBus eventBus)
        {
            this.eventBus = eventBus;
        }

        public void Publish(DomainEvent domainEvent)
        {
            eventBus.Dispatch(domainEvent);
        }
    }
}