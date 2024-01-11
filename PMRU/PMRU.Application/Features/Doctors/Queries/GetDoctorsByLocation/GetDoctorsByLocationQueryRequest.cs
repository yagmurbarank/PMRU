using MediatR;
using PMRU.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorsByLocation
{
    public class GetDoctorsByLocationQueryRequest : IRequest<IList<GetDoctorsByLocationQueryResponse>>
    {
        private int location;

        public GetDoctorsByLocationQueryRequest(int location)
        {
            this.location = location;
        }

        public DoctorDto Doctor { get; set; }
        public int LocationID { get; internal set; }
    }

}
