// --------------------------------------------------------------------------------------------------
// <copyright file="PaginatedEventLogFilterValidator.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;
using Microsoft.Extensions.Localization;
using Shared.Core.EventLogging;
using Shared.Core.Features.Common.Queries.Validators;
using Shared.DTOs.Identity.EventLogs;

namespace Shared.Infrastructure.Validators
{
    public class PaginatedEventLogFilterValidator : PaginatedFilterValidator<Guid, EventLog, PaginatedEventLogsFilter>
    {
        public PaginatedEventLogFilterValidator(IStringLocalizer<PaginatedEventLogFilterValidator> localizer)
            : base(localizer)
        {
            // you can override the validation rules here
        }
    }
}