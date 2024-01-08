using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentByDate
{
    public class GetAppointmentByDateQueryRequest : IRequest<IList<GetAppointmentByDateQueryResponse>>
    {
        public GetAppointmentByDateQueryRequest(DateOnly date)
        {
            Date = date;
        }
        public DateOnly Date { get; set; }
    }
}
