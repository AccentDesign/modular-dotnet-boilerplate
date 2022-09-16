using Shared.Core.Domain;

namespace Modules.EmployeeManagement.Core.Features.Staff.Events;
public class StaffEmployedEvent : Event
{
    public Guid Id { get; }

    public string FullName { get; }

    public StaffEmployedEvent(Entities.Staff staff)
    {
        Id = staff.Id;
        FullName = $"{staff.Name} {staff.Family}";
        RelatedEntities = new[] { typeof(Entities.Staff) };
    }
}