using PMRU.Application.DTOs;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorByRegistrationNumber
{
    public class GetDoctorByRegistrationNumberQueryResponseDto
    {
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int LocationID { get; set; }
        public LocationDto Location { get; set; }
        public string RegistrationNumber { get; set; }
        public IList<AppointmentDto> Appointments { get; set; }

        public IList<AvailabilityDto> Availabilities { get; set; }
    }
}
