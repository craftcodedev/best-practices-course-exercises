using System;
using App.Shared.Domain;

namespace App.Shared.Domain.Bus.Event
{
    public interface IEventHandler
    {
        void Handle(DomainEvent domainEvent);
    }
}