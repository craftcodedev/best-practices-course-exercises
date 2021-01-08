using System.Collections.Generic;
using elearning.Shared.Domain.Bus.Command;
using elearning.Shared.Domain.Bus.Event;
using elearning.Shared.Infrastructure.Bus.Event;

namespace elearning.Shared.Infrastructure.Bus.Command.Middleware
{
    public class EventDispatcherSyncMiddleware : MiddlewareHandler
    {
        private readonly IEventProvider eventProvider;
        private readonly IDomainEventPublisher domainEventPublisher;

        public EventDispatcherSyncMiddleware(IEventProvider eventProvider, IDomainEventPublisher domainEventPublisher)
        {
            this.eventProvider = eventProvider;
            this.domainEventPublisher = domainEventPublisher;
        }

        public override void Handle(ICommand command)
        {
            base.Handle(command);

            List<DomainEvent> events = eventProvider.ReleaseEvents();

            foreach (DomainEvent domainEvent in events)
            {
                domainEventPublisher.Publish(domainEvent);
            }
        }
    }
}