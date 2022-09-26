// --------------------------------------------------------------------------------------------------
// <copyright file="RemoveRoleExtendedAttributeCommandValidator.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Localization;
using Modules.Identity.Core.Entities;
using Shared.Core.Features.ExtendedAttributes.Commands.Validators;

namespace Modules.Identity.Core.Features.ExtendedAttributes.Validators.Roles
{
    public class RemoveRoleExtendedAttributeCommandValidator : RemoveExtendedAttributeCommandValidator<string, AccentRole>
    {
        public RemoveRoleExtendedAttributeCommandValidator(IStringLocalizer<RemoveRoleExtendedAttributeCommandValidator> localizer)
            : base(localizer)
        {
            // you can override the validation rules here
        }
    }
}