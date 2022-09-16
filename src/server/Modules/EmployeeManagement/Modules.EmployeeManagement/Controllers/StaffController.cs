using System.Net;
using Microsoft.AspNetCore.Mvc;
using Modules.EmployeeManagement.Core.Features.Staff.Commands;
using Shared.Infrastructure.Controllers;

namespace Modules.EmployeeManagement.Controllers
{
    [ApiVersion("1")]
    public class StaffController : BaseController
    {

        [HttpPost]
        public async Task<ActionResult> EmployStaffAsync(EmployStaffCommand command)
        {
            return StatusCode((int)HttpStatusCode.Created, await Mediator.Send(command));
        }
    }
}