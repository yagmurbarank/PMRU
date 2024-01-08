using MediatR;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentByAppointmentId
{
    public class GetAppointmentByAppointmentIdQueryRequest : IRequest<IList<GetAppointmentByAppointmentIdQueryResponse>>
    {
        public GetAppointmentByAppointmentIdQueryRequest(int appointmentId)
        {
            AppointmentId = appointmentId;
        }
        public int AppointmentId { get; set;}
    }
}
