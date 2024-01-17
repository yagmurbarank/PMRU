using PMRU.BlazorUI.Models.Doctor;
using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Models.Appointment
{
    public class AppointmentVM
    {
        public int EmployeeID { get; set; }
        public EmployeeVM Employee { get; set; }
        public int DoctorID { get; set; }
        public DoctorVM Doctor { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentHour { get; set; }
        public string Description { get; set; }

    }
}
