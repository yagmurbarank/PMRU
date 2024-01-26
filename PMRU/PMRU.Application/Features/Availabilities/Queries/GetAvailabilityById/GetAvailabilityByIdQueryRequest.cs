using MediatR;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilities;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilityById
{
    public class GetAvailabilityByIdQueryRequest: IRequest<GetAvailabilityByIdQueryResponseDto>, ICacheableQuery
    {
        public GetAvailabilityByIdQueryRequest(int id) 
        {
            Id = id;
        }

        public int Id { get; set; }

        public string CacheKey => $"GetAvailabilityById_{Id}";

        public double CacheTime => 5;
    }
}
