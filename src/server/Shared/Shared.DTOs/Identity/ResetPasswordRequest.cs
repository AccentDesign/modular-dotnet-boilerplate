// --------------------------------------------------------------------------------------------------
// <copyright file="ResetPasswordRequest.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

namespace Shared.DTOs.Identity
{
    public class ResetPasswordRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }
    }
}