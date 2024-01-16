using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Models
{
    public class DoctorVM
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
        public string RegistrationNumber { get; set; }
        public string Password { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Availability> Availabilities { get; set; }
    }
}
