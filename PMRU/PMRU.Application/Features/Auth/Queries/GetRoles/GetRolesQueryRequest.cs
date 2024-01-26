using MediatR;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilities;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Auth.Queries.GetRoles
{
    public class GetRolesQueryRequest : IRequest<IList<GetRolesQueryResponseDto>>, ICacheableQuery
    {
        public string CacheKey => $"GetRoles_{DateTime.Now:yyyyMMddHHmm}";

        public double CacheTime => 5;
    }
}
