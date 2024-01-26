using MediatR;
using PMRU.Application.Interfaces.RedisCache;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentById
{
    public class GetAppointmentByIdQueryRequest : IRequest<GetAppointmentByIdQueryResponseDto>, ICacheableQuery
    {
        public GetAppointmentByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set;}

        public string CacheKey => $"GetAppointmentById_{Id}";

        public double CacheTime => 1;
    }
}
