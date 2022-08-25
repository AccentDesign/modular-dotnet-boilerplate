// --------------------------------------------------------------------------------------------------
// <copyright file="RoleClaimDeletedEvent.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;
using Modules.Identity.Core.Entities;
using Shared.Core.Domain;

namespace Modules.Identity.Core.Features.RoleClaims.Events
{
    public class RoleClaimDeletedEvent : Event
    {
        public int Id { get; }

        public RoleClaimDeletedEvent(int id)
        {
            Id = id;
            AggregateId = Guid.NewGuid();
            RelatedEntities = new[] { typeof(FluentRoleClaim) };
        }
    }
}