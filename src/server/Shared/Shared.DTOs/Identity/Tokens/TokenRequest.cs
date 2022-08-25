// --------------------------------------------------------------------------------------------------
// <copyright file="TokenRequest.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

namespace Shared.DTOs.Identity.Tokens
{
    public record TokenRequest(string Email, string Password);
}