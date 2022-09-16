using Shared.Core.Domain;

namespace Modules.EmployeeManagement.Core.Entities
{
    /// <summary>
    /// Represent all staffs in company
    /// </summary>
    public class Staff : BaseEntity
    {

        public string NationalCode { get; set; }

        public string Name { get; set; }

        public string Family { get; set; }
        public DateTime EmployeedAt { get; set; }

        public ICollection<StaffTask> StaffTasks { get; set; }

        public static Staff InitializeStaff() => new Staff() { EmployeedAt = DateTime.UtcNow };

        public void AddTaskToStaff(IEnumerable<StaffTask> tasks)
        {
            foreach (var staffTask in tasks)
            {
                StaffTasks.Add(staffTask);
            }
        }

        public Staff() : base()
        {
            StaffTasks = new HashSet<StaffTask>();
        }
    }
}