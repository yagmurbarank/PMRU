using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Models
{
    public class AvailabilityVM
    {
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? LastModifiedDate { get; set; }
    }
}
