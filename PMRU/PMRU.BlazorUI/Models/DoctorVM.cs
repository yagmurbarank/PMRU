using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Models
{
    public class DoctorVM
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public LocationVM Location { get; set; }
        public ICollection<AvailabilityVM> Availabilities { get; set; }
    }
}
