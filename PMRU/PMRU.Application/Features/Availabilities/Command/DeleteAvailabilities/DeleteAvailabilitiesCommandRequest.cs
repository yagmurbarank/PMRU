using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.DeleteAvailabilities
{
    public class DeleteAvailabilitiesCommandRequest: IRequest
    {
        public IList<int> Ids { get; set; }
    }
}
