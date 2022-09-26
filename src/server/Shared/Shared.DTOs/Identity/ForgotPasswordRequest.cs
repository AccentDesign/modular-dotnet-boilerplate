// --------------------------------------------------------------------------------------------------
// <copyright file="ForgotPasswordRequest.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace Shared.DTOs.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}