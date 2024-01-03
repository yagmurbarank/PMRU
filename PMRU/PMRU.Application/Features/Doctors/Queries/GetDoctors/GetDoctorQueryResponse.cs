using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctors
{
    public class GetDoctorQueryResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Location Location { get; set; }
        public ICollection<Availability> Availabilities { get; set; }
    }
}
