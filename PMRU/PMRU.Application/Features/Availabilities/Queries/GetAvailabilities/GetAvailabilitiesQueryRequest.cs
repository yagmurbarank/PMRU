using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilities
{
    public class GetAvailabilitiesQueryRequest: IRequest<IList<GetAvailabilitiesQueryResponse>>
    {
    }
}
