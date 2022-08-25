// --------------------------------------------------------------------------------------------------
// <copyright file="IdentityException.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Net;
using Shared.Core.Exceptions;

namespace Modules.Identity.Core.Exceptions
{
    public class IdentityException : CustomException
    {
        public IdentityException(string message, List<string> errors = default, HttpStatusCode statusCode = default)
            : base(message, errors, statusCode)
        {
        }
    }
}