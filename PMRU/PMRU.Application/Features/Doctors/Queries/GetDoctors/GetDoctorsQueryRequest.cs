using MediatR;
using PMRU.Application.Features.Appointments.Queires.GetAppointments;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctors
{
    public class GetDoctorsQueryRequest : IRequest<IList<GetDoctorsQueryResponseDto>>, ICacheableQuery
    {
        public GetDoctorsQueryRequest()
        {
        }

        public GetDoctorsQueryRequest(int location)
        {
            Location = location;
        }

        public int Location { get; }

        public string CacheKey => "GetDoctors_{DateTime.Now:yyyyMMddHHmm}";

        public double CacheTime => 1;
    }
}
