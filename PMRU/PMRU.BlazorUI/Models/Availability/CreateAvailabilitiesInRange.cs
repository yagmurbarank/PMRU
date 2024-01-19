namespace PMRU.BlazorUI.Models.Availability
{
    public class CreateAvailabilitiesInRange
    {
        public int DoctorID { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int Duration { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
