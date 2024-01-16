using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.UpdateAvailability
{
    public class UpdateAvailabilityCommandRequest: IRequest<Unit>
    {
        public int Id { get; set; }
        public int DoctorID { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
