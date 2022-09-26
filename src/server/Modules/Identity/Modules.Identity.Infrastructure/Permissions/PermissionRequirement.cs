// --------------------------------------------------------------------------------------------------
// <copyright file="PermissionRequirement.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.AspNetCore.Authorization;

namespace Modules.Identity.Infrastructure.Permissions
{
    internal class PermissionRequirement : IAuthorizationRequirement
    {
        public string Permission { get; private set; }

        public PermissionRequirement(string permission)
        {
            Permission = permission;
        }
    }
}