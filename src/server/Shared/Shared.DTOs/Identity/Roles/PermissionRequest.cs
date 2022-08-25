// --------------------------------------------------------------------------------------------------
// <copyright file="PermissionRequest.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Shared.DTOs.Identity.Roles
{
    public class PermissionRequest
    {
        public string RoleId { get; set; }

        public IList<RoleClaimModel> RoleClaims { get; set; }
    }
}