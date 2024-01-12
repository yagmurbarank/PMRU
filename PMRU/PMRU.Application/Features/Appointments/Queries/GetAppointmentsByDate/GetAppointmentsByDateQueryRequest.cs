using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentsByDate
{
    public class GetAppointmentsByDateQueryRequest : IRequest<IList<GetAppointmentsByDateQueryResponseDto>>
    {
        public GetAppointmentsByDateQueryRequest(DateOnly date)
        {
            Date = date;
        }
        public DateOnly Date { get; set; }
    }
}
