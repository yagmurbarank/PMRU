using PMRU.BlazorUI.Models.Doctor;
using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Models.Availability
{
    public class AvailabilityVM
    {
        public int Id { get; set; }
        public int DoctorID { get; set; }
        public DoctorVM Doctor { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

    }
}
