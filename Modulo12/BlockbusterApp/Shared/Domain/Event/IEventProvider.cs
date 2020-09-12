using System;
using System.Collections.Generic;

namespace BlockbusterApp.src.Shared.Domain.Event
{
    public interface IEventProvider
    {
        void RecordEvents(List<DomainEvent> domainEvents);
        List<DomainEvent> ReleaseEvents();
    }
}
