// --------------------------------------------------------------------------------------------------
// <copyright file="RefreshTokenRequest.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

namespace Shared.DTOs.Identity.Tokens
{
    public record RefreshTokenRequest(string Token, string RefreshToken);
}