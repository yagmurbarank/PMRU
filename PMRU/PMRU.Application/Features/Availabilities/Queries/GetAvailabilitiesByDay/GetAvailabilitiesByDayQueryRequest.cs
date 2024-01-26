using MediatR;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByDay
{
    public class GetAvailabilitiesByDayQueryRequest: IRequest<IList<GetAvailabilitiesByDayQueryResponseDto>>, ICacheableQuery
    {
        public GetAvailabilitiesByDayQueryRequest(DateOnly date)
        {
            Date = date;
        }

        public DateOnly Date { get; set; }

        public string CacheKey => $"GetAvailabilitiesByDay_{Date.ToString("yyyyMMdd")}";

        public double CacheTime => 1;
    }
}
