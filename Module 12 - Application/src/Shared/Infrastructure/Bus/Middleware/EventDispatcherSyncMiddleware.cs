using App.Shared.Domain.Bus.Middleware;
using App.Shared.Domain.Bus.UseCase;
using App.Shared.Domain.Bus.Event;
using App.Shared.Domain;
using System;
using System.Collections.Generic;

namespace App.Shared.Infrastructure.Bus.Middleware
{
    public class EventDispatcherSyncMiddleware : MiddlewareHandler
    {
        private EventProvider eventProvider;
        private IEventBus eventBus;

        public EventDispatcherSyncMiddleware(EventProvider eventProvider, IEventBus eventBus)
        {
            this.eventProvider = eventProvider;
            this.eventBus = eventBus;
        }
        public override IResponse Handle(IRequest request)
        {
            System.Console.WriteLine("EventDispatcherSyncMiddleware");
            IResponse response = base.Handle(request);

            List<DomainEvent> events = this.eventProvider.ReleaseEvents();

            foreach(DomainEvent domainEvent in events) {
                this.eventBus.Dispatch(domainEvent);
            }

            return response;
        }
    }
}