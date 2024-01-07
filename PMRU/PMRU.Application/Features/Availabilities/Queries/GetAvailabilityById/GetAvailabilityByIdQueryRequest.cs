using MediatR;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilityById
{
    public class GetAvailabilityByIdQueryRequest: IRequest<GetAvailabilityByIdQueryResponse>
    {
        public GetAvailabilityByIdQueryRequest(int id) 
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
