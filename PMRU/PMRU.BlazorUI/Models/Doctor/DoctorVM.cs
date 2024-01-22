using PMRU.BlazorUI.Models.Appointment;
using PMRU.BlazorUI.Models.Availability;
using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Models.Doctor
{
    public class DoctorVM
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public LocationVM Location { get; set; }
        public ICollection<AvailabilityVM> Availabilities { get; set; }
        public ICollection<AppointmentVM> Appointments { get; set; }
    }
}
