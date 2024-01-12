using MediatR;
using PMRU.Application.Features.Appointments.Queires.GetAppointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctors
{
    public class GetDoctorsQueryRequest : IRequest<IList<GetDoctorsQueryResponseDto>>
    {
        public GetDoctorsQueryRequest()
        {
        }

        public GetDoctorsQueryRequest(int location)
        {
            Location = location;
        }

        public int Location { get; }
    }
}
