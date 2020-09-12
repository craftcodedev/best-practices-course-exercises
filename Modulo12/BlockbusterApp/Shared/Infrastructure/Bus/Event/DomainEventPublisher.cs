using BlockbusterApp.src.Shared.Domain.Event;

namespace BlockbusterApp.src.Shared.Infrastructure.Bus.Event
{
    public class DomainEventPublisherSync : IDomainEventPublisher
    {
        private IEventBus eventBus;

        public DomainEventPublisherSync(IEventBus eventBus)
        {
            this.eventBus = eventBus;
        }

        public void Publish(DomainEvent domainEvent)
        {
            this.eventBus.Dispatch(domainEvent);
        }
    }
}
