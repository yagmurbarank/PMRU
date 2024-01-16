using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByStartTime
{
    public class GetAvailabilitiesByStartTimeQueryRequest: IRequest<IList<GetAvailabilitiesByStartTimeQueryResponseDto>>
    {
        public GetAvailabilitiesByStartTimeQueryRequest(TimeOnly startTime)
        {
            StartTime = startTime;
        }

        public TimeOnly StartTime { get; set; }
    }
}
