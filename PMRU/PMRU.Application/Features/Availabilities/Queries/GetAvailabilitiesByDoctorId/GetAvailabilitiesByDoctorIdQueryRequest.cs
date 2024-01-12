using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByDoctorId
{
    public class GetAvailabilitiesByDoctorIdQueryRequest: IRequest<IList<GetAvailabilitiesByDoctorIdQueryResponseDto>>
    {
        public GetAvailabilitiesByDoctorIdQueryRequest(int doctorId)
        {
            DoctorId = doctorId;
        }

        public int DoctorId { get; set; }
    }
}
