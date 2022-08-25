// --------------------------------------------------------------------------------------------------
// <copyright file="UpdateRoleExtendedAttributeCommandValidator.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Localization;
using Modules.Identity.Core.Entities;
using Shared.Core.Features.ExtendedAttributes.Commands.Validators;
using Shared.Core.Interfaces.Serialization;

namespace Modules.Identity.Core.Features.ExtendedAttributes.Validators.Roles
{
    public class UpdateRoleExtendedAttributeCommandValidator : UpdateExtendedAttributeCommandValidator<string, AccentRole>
    {
        public UpdateRoleExtendedAttributeCommandValidator(IStringLocalizer<UpdateRoleExtendedAttributeCommandValidator> localizer, IJsonSerializer jsonSerializer)
            : base(localizer, jsonSerializer)
        {
            // you can override the validation rules here
        }
    }
}