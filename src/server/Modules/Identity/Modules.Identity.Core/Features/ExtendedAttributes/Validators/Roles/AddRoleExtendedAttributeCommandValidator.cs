// --------------------------------------------------------------------------------------------------
// <copyright file="AddRoleExtendedAttributeCommandValidator.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Localization;
using Modules.Identity.Core.Entities;
using Shared.Core.Features.ExtendedAttributes.Commands.Validators;
using Shared.Core.Interfaces.Serialization;

namespace Modules.Identity.Core.Features.ExtendedAttributes.Validators.Roles
{
    public class AddRoleExtendedAttributeCommandValidator : AddExtendedAttributeCommandValidator<string, AccentRole>
    {
        public AddRoleExtendedAttributeCommandValidator(IStringLocalizer<AddRoleExtendedAttributeCommandValidator> localizer, IJsonSerializer jsonSerializer)
            : base(localizer, jsonSerializer)
        {
            // you can override the validation rules here
        }
    }
}