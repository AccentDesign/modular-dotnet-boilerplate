// --------------------------------------------------------------------------------------------------
// <copyright file="AccentRoleClaim.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Shared.Core.Contracts;
using Shared.Core.Domain;

namespace Modules.Identity.Core.Entities
{
    public class AccentRoleClaim : IdentityRoleClaim<string>, IBaseEntity
    {
        public string Description { get; set; }

        public string Group { get; set; }

        public virtual AccentRole Role { get; set; }

        private List<Event> _domainEvents;

        public IReadOnlyCollection<Event> DomainEvents => _domainEvents?.AsReadOnly();

        public void AddDomainEvent(Event domainEvent)
        {
            _domainEvents ??= new List<Event>();
            _domainEvents.Add(domainEvent);
        }

        public void RemoveDomainEvent(Event domainEvent)
        {
            _domainEvents?.Remove(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        public AccentRoleClaim()
            : base()
        {
        }

        public AccentRoleClaim(string roleClaimDescription = null, string roleClaimGroup = null)
            : base()
        {
            Description = roleClaimDescription;
            Group = roleClaimGroup;
        }
    }
}