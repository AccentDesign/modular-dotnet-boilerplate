// --------------------------------------------------------------------------------------------------
// <copyright file="AccentRole.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Modules.Identity.Core.Entities.ExtendedAttributes;
using Shared.Core.Contracts;
using Shared.Core.Domain;

namespace Modules.Identity.Core.Entities
{
    public class AccentRole : IdentityRole, IEntity<string>, IBaseEntity
    {
        public string Description { get; set; }

        public virtual ICollection<AccentRoleClaim> RoleClaims { get; set; }

        public virtual ICollection<RoleExtendedAttribute> ExtendedAttributes { get; set; }

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

        public AccentRole()
            : base()
        {
            RoleClaims = new HashSet<AccentRoleClaim>();
            ExtendedAttributes = new HashSet<RoleExtendedAttribute>();
        }

        public AccentRole(string roleName, string roleDescription = null)
            : base(roleName)
        {
            RoleClaims = new HashSet<AccentRoleClaim>();
            ExtendedAttributes = new HashSet<RoleExtendedAttribute>();
            Description = roleDescription;
        }
    }
}