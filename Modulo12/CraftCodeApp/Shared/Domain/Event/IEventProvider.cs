using System;
using System.Collections.Generic;

namespace CraftCodeApp.src.Shared.Domain.Event
{
    public interface IEventProvider
    {
        void RecordEvents(List<DomainEvent> domainEvents);
        List<DomainEvent> ReleaseEvents();
    }
}
