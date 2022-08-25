// --------------------------------------------------------------------------------------------------
// <copyright file="BaseController.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Shared.Infrastructure.Controllers;

namespace Modules.Identity.Controllers
{
    [ApiController]
    [Route(BasePath + "/[controller]")]
    internal abstract class BaseController : CommonBaseController
    {
        protected internal new const string BasePath = CommonBaseController.BasePath + "/identity";
    }
}