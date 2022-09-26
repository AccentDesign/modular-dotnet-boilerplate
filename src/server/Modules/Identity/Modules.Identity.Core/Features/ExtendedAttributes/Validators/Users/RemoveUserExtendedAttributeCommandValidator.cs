// --------------------------------------------------------------------------------------------------
// <copyright file="RemoveUserExtendedAttributeCommandValidator.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Localization;
using Modules.Identity.Core.Entities;
using Shared.Core.Features.ExtendedAttributes.Commands.Validators;

namespace Modules.Identity.Core.Features.ExtendedAttributes.Validators.Users
{
    public class RemoveUserExtendedAttributeCommandValidator : RemoveExtendedAttributeCommandValidator<string, AccentUser>
    {
        public RemoveUserExtendedAttributeCommandValidator(IStringLocalizer<RemoveUserExtendedAttributeCommandValidator> localizer)
            : base(localizer)
        {
            // you can override the validation rules here
        }
    }
}