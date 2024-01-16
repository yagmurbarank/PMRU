using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Models
{
    public class AppointmentVM
    {
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentHour { get; set; }
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? LastModifiedDate { get; set; }
    }
}
