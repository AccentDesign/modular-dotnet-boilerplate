// --------------------------------------------------------------------------------------------------
// <copyright file="RemoveExtendedAttributeCommandValidator.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;
using FluentValidation;
using Microsoft.Extensions.Localization;
using Shared.Core.Contracts;

namespace Shared.Core.Features.ExtendedAttributes.Commands.Validators
{
    public abstract class RemoveExtendedAttributeCommandValidator<TEntityId, TEntity> : AbstractValidator<RemoveExtendedAttributeCommand<TEntityId, TEntity>>
        where TEntity : class, IEntity<TEntityId>
    {
        protected RemoveExtendedAttributeCommandValidator(IStringLocalizer localizer)
        {
            RuleFor(request => request.Id)
                .NotEqual(Guid.Empty).WithMessage(_ => localizer["The {PropertyName} property cannot be empty."]);
        }
    }
}