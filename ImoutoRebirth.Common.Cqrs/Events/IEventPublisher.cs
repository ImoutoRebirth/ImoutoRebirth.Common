﻿using System.Threading;
using System.Threading.Tasks;
using ImoutoRebirth.Common.Domain;

namespace ImoutoRebirth.Common.Cqrs.Events
{
    public interface IEventPublisher
    {
        Task Publish<TEvent>(TEvent e, CancellationToken cancellationToken) where TEvent : IDomainEvent;
    }
}