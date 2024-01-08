using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentsByDoctorId
{
    public class GetAppointmentsByDoctorIdQueryRequest : IRequest<IList<GetAppointmentsByDoctorIdQueryResponse>>
    {
        public GetAppointmentsByDoctorIdQueryRequest(int doctorId)
        {
            DoctorId = doctorId;
        }

        public int DoctorId { get; set; }
    }
}
