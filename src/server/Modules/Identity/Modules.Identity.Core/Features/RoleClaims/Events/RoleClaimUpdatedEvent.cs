// --------------------------------------------------------------------------------------------------
// <copyright file="RoleClaimUpdatedEvent.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;
using Modules.Identity.Core.Entities;
using Shared.Core.Domain;

namespace Modules.Identity.Core.Features.RoleClaims.Events
{
    public class RoleClaimUpdatedEvent : Event
    {
        public int Id { get; }

        public string RoleId { get; }

        public string ClaimType { get; }

        public string ClaimValue { get; }

        public string Group { get; }

        public string Description { get; }

        public RoleClaimUpdatedEvent(FluentRoleClaim roleClaim)
        {
            RoleId = roleClaim.RoleId;
            Group = roleClaim.Group;
            ClaimType = roleClaim.ClaimType;
            ClaimValue = roleClaim.ClaimValue;
            Description = roleClaim.Description;
            Id = roleClaim.Id;
            AggregateId = Guid.NewGuid();
            RelatedEntities = new[] { typeof(FluentRoleClaim) };
        }
    }
}