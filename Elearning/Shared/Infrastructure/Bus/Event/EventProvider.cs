using System.Collections.Generic;
using elearning.Shared.Domain.Bus.Event;

namespace elearning.Shared.Infrastructure.Bus.Event
{
    public class EventProvider : IEventProvider
    {
        private List<DomainEvent> events;

        public EventProvider()
        {
            events = new List<DomainEvent>();
        }

        public void RecordEvents(List<DomainEvent> domainEvents)
        {
            foreach (DomainEvent domainEvent in domainEvents)
            {
                Record(domainEvent);
            }
        }

        private void Record(DomainEvent domainEvent)
        {
            events.Add(domainEvent);
        }

        public List<DomainEvent> ReleaseEvents()
        {
            List<DomainEvent> events = this.events;
            RemoveEvents();

            return events;
        }

        private void RemoveEvents()
        {
            events = new List<DomainEvent>();
        }
    }
}