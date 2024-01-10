using MediatR;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentById
{
    public class GetAppointmentByIdQueryRequest : IRequest<IList<GetAppointmentByIdQueryResponse>>
    {
        public GetAppointmentByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set;}
    }
}
