// --------------------------------------------------------------------------------------------------
// <copyright file="DomainEvent.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;

namespace Shared.Core.Domain
{
    public abstract class DomainEvent : Event
    {
        protected DomainEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}