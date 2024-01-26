using MediatR;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByStartTime
{
    public class GetAvailabilitiesByStartTimeQueryRequest: IRequest<IList<GetAvailabilitiesByStartTimeQueryResponseDto>>, ICacheableQuery
    {
        public GetAvailabilitiesByStartTimeQueryRequest(TimeOnly startTime)
        {
            StartTime = startTime;
        }

        public TimeOnly StartTime { get; set; }

        public string CacheKey => $"GetAvailabilityByStartTime_{StartTime.ToString("hhmmss")}";

        public double CacheTime => 1;
    }
}
