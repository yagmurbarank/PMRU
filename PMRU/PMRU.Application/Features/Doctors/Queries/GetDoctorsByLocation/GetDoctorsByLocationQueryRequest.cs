using MediatR;
using PMRU.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorsByLocation
{
    public class GetDoctorsByLocationQueryRequest : IRequest<IList<GetDoctorsByLocationQueryResponseDto>>
    {
        public int LocationID { get; internal set; }
        public GetDoctorsByLocationQueryRequest(int locationId)
        {
            this.LocationID = locationId;
        }
    }

}
