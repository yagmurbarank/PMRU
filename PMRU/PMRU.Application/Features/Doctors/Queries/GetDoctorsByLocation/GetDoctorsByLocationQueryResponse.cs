using PMRU.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorsByLocation
{

    public class GetDoctorsByLocationQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int LocationId { get; set; }
        public LocationDto Location { get; set; }
        public IList<AvailabilityDto> Availability { get; set; }
    }
}
