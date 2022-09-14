using System.Net;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Modules.EmployeeManagement.Core.Abstractions;
using Modules.EmployeeManagement.Core.Exception;
using Shared.Core.Wrapper;

namespace Modules.EmployeeManagement.Core.Features.Staff.Commands;
public class StaffCommandHandler : IRequestHandler<EmployStaffCommand, Result<Guid>>
{
    private readonly IStringLocalizer<StaffCommandHandler> _localizer;
    private readonly IStaffManagementDbContext _staffManagementDbContext;

    public StaffCommandHandler(IStringLocalizer<StaffCommandHandler> localizer)
    {
        _localizer = localizer;
    }
    public StaffCommandHandler(IStaffManagementDbContext staffManagementDbContext)
    {
        _staffManagementDbContext = staffManagementDbContext;
    }
    public async Task<Result<Guid>> Handle(EmployStaffCommand request, CancellationToken cancellationToken)
    {
        if (await _staffManagementDbContext.Staves.AnyAsync(x => x.NationalCode == request.NationalCode))
            throw new StaffException(_localizer["Staff with the same nationalcode already exists."],HttpStatusCode.BadRequest);

        return await Result<Guid>.SuccessAsync("fdfd");
    }
}