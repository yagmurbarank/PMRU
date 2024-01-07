using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByDay
{
    public class GetAvailabilitiesByDayQueryRequest: IRequest<IList<GetAvailabilitiesByDayQueryResponse>>
    {
        public GetAvailabilitiesByDayQueryRequest(DayOfWeek day)
        {
            Day = day;
        }

        public DayOfWeek Day { get; set; }
    }
}
