// --------------------------------------------------------------------------------------------------
// <copyright file="LogEventRequest.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;

namespace Shared.DTOs.Identity.EventLogs
{
    public class LogEventRequest
    {
        public LogEventRequest()
        {
        }

        public string Event { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public Guid UserId { get; set; }
    }
}