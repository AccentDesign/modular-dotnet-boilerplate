// --------------------------------------------------------------------------------------------------
// <copyright file="Message.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;
using Shared.Core.Utilities;

namespace Shared.Core.Domain
{
    public abstract class Message
    {
        public string MessageType { get; protected set; }

        public Guid AggregateId { get; protected set; }

        protected Message()
        {
            MessageType = GetType().GetGenericTypeName();
        }
    }
}