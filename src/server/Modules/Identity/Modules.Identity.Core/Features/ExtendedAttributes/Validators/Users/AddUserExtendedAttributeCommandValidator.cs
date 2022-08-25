// --------------------------------------------------------------------------------------------------
// <copyright file="AddUserExtendedAttributeCommandValidator.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Localization;
using Modules.Identity.Core.Entities;
using Shared.Core.Features.ExtendedAttributes.Commands.Validators;
using Shared.Core.Interfaces.Serialization;

namespace Modules.Identity.Core.Features.ExtendedAttributes.Validators.Users
{
    public class AddUserExtendedAttributeCommandValidator : AddExtendedAttributeCommandValidator<string, AccentUser>
    {
        public AddUserExtendedAttributeCommandValidator(IStringLocalizer<AddUserExtendedAttributeCommandValidator> localizer, IJsonSerializer jsonSerializer)
            : base(localizer, jsonSerializer)
        {
            // you can override the validation rules here
        }
    }
}