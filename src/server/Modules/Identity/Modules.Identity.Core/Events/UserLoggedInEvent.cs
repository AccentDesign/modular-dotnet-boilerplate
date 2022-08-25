// --------------------------------------------------------------------------------------------------
// <copyright file="UserLoggedInEvent.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;
using Modules.Identity.Core.Entities;
using Shared.Core.Domain;

namespace Modules.Identity.Core.Events
{
    public class UserLoggedInEvent : Event
    {
        public Guid UserId { get; }

        public new DateTime Timestamp { get; }

        public UserLoggedInEvent(Guid userId)
        {
            UserId = userId;
            Timestamp = DateTime.Now;
            AggregateId = userId;
            RelatedEntities = new[] { typeof(AccentUser) };
        }
    }
}