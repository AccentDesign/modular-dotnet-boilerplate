// --------------------------------------------------------------------------------------------------
// <copyright file="UpdateUserExtendedAttributeCommandValidator.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Localization;
using Modules.Identity.Core.Entities;
using Shared.Core.Features.ExtendedAttributes.Commands.Validators;
using Shared.Core.Interfaces.Serialization;

namespace Modules.Identity.Core.Features.ExtendedAttributes.Validators.Users
{
    public class UpdateUserExtendedAttributeCommandValidator : UpdateExtendedAttributeCommandValidator<string, AccentUser>
    {
        public UpdateUserExtendedAttributeCommandValidator(IStringLocalizer<UpdateUserExtendedAttributeCommandValidator> localizer, IJsonSerializer jsonSerializer)
            : base(localizer, jsonSerializer)
        {
            // you can override the validation rules here
        }
    }
}