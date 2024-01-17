using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentByEmployeeId
{
    public class GetAppointmentByEmployeeIdQueryRequest : IRequest<GetAppointmentByEmployeeIdQueryResponseDto>
    {
        public GetAppointmentByEmployeeIdQueryRequest(int employeeId)
        {
            EmployeeId = employeeId;
        }

        public int EmployeeId { get; set; }
    }
}
