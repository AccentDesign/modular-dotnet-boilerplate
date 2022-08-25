// --------------------------------------------------------------------------------------------------
// <copyright file="UserDeletedEvent.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;
using Modules.Identity.Core.Entities;
using Shared.Core.Domain;

namespace Modules.Identity.Core.Features.Users.Events
{
    public class UserDeletedEvent : Event
    {
        public string Id { get; }

        public UserDeletedEvent(string id)
        {
            Id = id;
            AggregateId = Guid.TryParse(id, out var aggregateId)
                ? aggregateId
                : Guid.NewGuid();
            RelatedEntities = new[] { typeof(AccentUser) };
        }
    }
}