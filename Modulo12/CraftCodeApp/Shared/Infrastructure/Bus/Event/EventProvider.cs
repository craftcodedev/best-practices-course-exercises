using System.Collections.Generic;
using CraftCodeApp.src.Shared.Domain.Event;

namespace CraftCodeApp.src.Shared.Infrastructure.Bus.Event
{
    public class EventProvider : IEventProvider
    {
        private List<DomainEvent> events;

        public EventProvider()
        {
            this.events = new List<DomainEvent>();
        }

        public void RecordEvents(List<DomainEvent> domainEvents)
        {
            foreach (DomainEvent domainEvent in domainEvents)
            {
                this.Record(domainEvent);
            }
        }

        private void Record(DomainEvent domainEvent)
        {
            this.events.Add(domainEvent);
        }

        public List<DomainEvent> ReleaseEvents()
        {
            List<DomainEvent> events = this.events;
            this.RemoveEvents();

            return events;
        }

        private void RemoveEvents()
        {
            this.events = new List<DomainEvent>();
        }
    }
}
