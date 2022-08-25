// --------------------------------------------------------------------------------------------------
// <copyright file="PermissionResponse.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Shared.DTOs.Identity.Roles
{
    public class PermissionResponse
    {
        public string RoleId { get; set; }

        public string RoleName { get; set; }

        public List<RoleClaimModel> RoleClaims { get; set; }
    }
}