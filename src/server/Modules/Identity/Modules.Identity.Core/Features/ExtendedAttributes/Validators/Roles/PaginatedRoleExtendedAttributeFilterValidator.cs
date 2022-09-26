// --------------------------------------------------------------------------------------------------
// <copyright file="PaginatedRoleExtendedAttributeFilterValidator.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Localization;
using Modules.Identity.Core.Entities;
using Shared.Core.Features.ExtendedAttributes.Queries.Validators;

namespace Modules.Identity.Core.Features.ExtendedAttributes.Validators.Roles
{
    public class PaginatedRoleExtendedAttributeFilterValidator : PaginatedExtendedAttributeFilterValidator<string, AccentRole>
    {
        public PaginatedRoleExtendedAttributeFilterValidator(IStringLocalizer<PaginatedRoleExtendedAttributeFilterValidator> localizer)
            : base(localizer)
        {
            // you can override the validation rules here
        }
    }
}