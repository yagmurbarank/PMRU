using MediatR;
using PMRU.Application.Features.Availabilities.Command.CreateAvailability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.CreateAvailabilities
{
    public class CreateAvailabilitiesCommandRequest: IRequest
    {
        public IList<CreateAvailabilityCommandRequest> AvailabilityRequests { get; set; }
    }
}
