// --------------------------------------------------------------------------------------------------
// <copyright file="UserExtendedAttributesController.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.Identity.Core.Entities;
using Shared.Core.Constants;
using Shared.Core.Domain;
using Shared.Core.Features.Common.Filters;
using Shared.Core.Features.ExtendedAttributes.Commands;
using Shared.Core.Features.ExtendedAttributes.Filters;
using Shared.Infrastructure.Controllers;

namespace Modules.Identity.Controllers.ExtendedAttributes
{
    [ApiVersion("1")]
    [Route(BaseController.BasePath + "/user/attributes")]
    internal sealed class UserExtendedAttributesController : ExtendedAttributesController<string, AccentUser>
    {
        [Authorize(Policy = Permissions.UsersExtendedAttributes.ViewAll)]
        public override Task<IActionResult> GetAllAsync(PaginatedExtendedAttributeFilter<string, AccentUser> filter)
        {
            return base.GetAllAsync(filter);
        }

        [Authorize(Policy = Permissions.UsersExtendedAttributes.View)]
        public override Task<IActionResult> GetByIdAsync([FromQuery] GetByIdCacheableFilter<Guid, ExtendedAttribute<string, AccentUser>> filter)
        {
            return base.GetByIdAsync(filter);
        }

        [Authorize(Policy = Permissions.UsersExtendedAttributes.Add)]
        public override Task<IActionResult> CreateAsync(AddExtendedAttributeCommand<string, AccentUser> command)
        {
            return base.CreateAsync(command);
        }

        [Authorize(Policy = Permissions.UsersExtendedAttributes.Update)]
        public override Task<IActionResult> UpdateAsync(UpdateExtendedAttributeCommand<string, AccentUser> command)
        {
            return base.UpdateAsync(command);
        }

        [Authorize(Policy = Permissions.UsersExtendedAttributes.Remove)]
        public override Task<IActionResult> RemoveAsync(Guid id)
        {
            return base.RemoveAsync(id);
        }
    }
}