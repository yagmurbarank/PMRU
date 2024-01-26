using MediatR;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queires.GetAppointments
{
    public class GetAppointmentsQueryRequest : IRequest<IList<GetAppointmentsQueryResponseDto>>, ICacheableQuery
    {
        public string CacheKey => $"GetAppointments_{DateTime.Now:yyyyMMddHHmm}";

        public double CacheTime => 5;
    }
}