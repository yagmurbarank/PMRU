using MediatR;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByDoctorId
{
    public class GetAvailabilitiesByDoctorIdQueryRequest: IRequest<IList<GetAvailabilitiesByDoctorIdQueryResponseDto>> , ICacheableQuery
    {
        public GetAvailabilitiesByDoctorIdQueryRequest(int doctorId)
        {
            DoctorId = doctorId;
        }

        public int DoctorId { get; set; }

        public string CacheKey => $"GetAvailabilityByDoctorId_{DoctorId}";

        public double CacheTime => 5;
    }
}
