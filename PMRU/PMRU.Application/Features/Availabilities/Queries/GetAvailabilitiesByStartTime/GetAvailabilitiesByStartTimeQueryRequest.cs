using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByStartTime
{
    public class GetAvailabilitiesByStartTimeQueryRequest: IRequest<IList<GetAvailabilitiesByStartTimeQueryResponse>>
    {
        public GetAvailabilitiesByStartTimeQueryRequest(TimeSpan startTime)
        {
            StartTime = startTime;
        }

        public TimeSpan StartTime { get; set; }
    }
}
