// --------------------------------------------------------------------------------------------------
// <copyright file="RoleClaimResponse.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

namespace Shared.DTOs.Identity.Roles
{
    public class RoleClaimResponse
    {
        public int Id { get; set; }

        public string RoleId { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }

        public string Group { get; set; }
    }
}