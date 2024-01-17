namespace PMRU.BlazorUI.Models.Appointment
{
    public class CreateAppointmentVM
    {
        public int EmployeeID { get; set; }
        public int DoctorID { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentHour { get; set; }
        public string Description { get; set; }
    }
}
