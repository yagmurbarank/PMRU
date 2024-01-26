using MediatR;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilities
{
    public class GetAvailabilitiesQueryRequest: IRequest<IList<GetAvailabilitiesQueryResponseDto>>, ICacheableQuery
    {
        public string CacheKey => $"GetAvailabilities_{DateTime.Now:yyyyMMddHHmm}";

        public double CacheTime => 5;
    }
}
