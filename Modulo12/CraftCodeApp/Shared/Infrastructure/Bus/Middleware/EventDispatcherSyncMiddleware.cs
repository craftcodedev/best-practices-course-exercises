using System.Collections.Generic;
using CraftCodeApp.src.Shared.Application.Bus.UseCase;
using CraftCodeApp.src.Shared.Domain.Event;
using CraftCodeApp.src.Shared.Infrastructure.Bus.Event;

namespace CraftCodeApp.src.Shared.Infrastructure.Bus.Middleware
{
        public class EventDispatcherSyncMiddleware : MiddlewareHandler
        {
            private IEventProvider eventProvider;
            private IDomainEventPublisher domainEventPublisher;

            public EventDispatcherSyncMiddleware(IEventProvider eventProvider, IDomainEventPublisher domainEventPublisher)
            {
                this.eventProvider = eventProvider;
                this.domainEventPublisher = domainEventPublisher;
            }

            public override IResponse Handle(IRequest request)
            {
                IResponse response = base.Handle(request);

                List<DomainEvent> events = this.eventProvider.ReleaseEvents();

                foreach (DomainEvent domainEvent in events)
                {
                    domainEventPublisher.Publish(domainEvent);
                }

                return response;
            }
        }
}
