using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.DeleteAvailability
{
    public class DeleteAvailabilityCommandRequest: IRequest
    {
        public int Id { get; set; }
    }
}
