// --------------------------------------------------------------------------------------------------
// <copyright file="RoleAddedEvent.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;
using Modules.Identity.Core.Entities;
using Shared.Core.Domain;

namespace Modules.Identity.Core.Features.Roles.Events
{
    public class RoleAddedEvent : Event
    {
        public string Id { get; }

        public string Name { get; }

        public string Description { get; }

        public RoleAddedEvent(AccentRole role)
        {
            Name = role.Name;
            Description = role.Description;
            Id = role.Id;
            AggregateId = Guid.TryParse(role.Id, out var aggregateId)
                ? aggregateId
                : Guid.NewGuid();
            RelatedEntities = new[] { typeof(AccentRole) };
        }
    }
}