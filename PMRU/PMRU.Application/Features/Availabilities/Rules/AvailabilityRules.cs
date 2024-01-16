using PMRU.Application.Bases;
using PMRU.Application.Features.Availabilities.Exceptions;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Rules
{
    public class AvailabilityRules : BaseRules
    {
        public Task DoctorCannotHaveAvailabilityAtTheSameTime(IList<Availability> availabilities, int doctorId, DateOnly date, TimeOnly startTime, TimeOnly endTime)
        {
            foreach (var availability in availabilities)
            {
                if (availability.DoctorID == doctorId && availability.Date == date)
                {
                    if ((availability.StartTime <= startTime && availability.EndTime > startTime) || (availability.StartTime < endTime && availability.EndTime >= endTime) || (availability.StartTime >= startTime && availability.EndTime <= endTime))
                        throw new DoctorCannotHaveAvailabilityAtTheSameTimeException();
                }
            }
            return Task.CompletedTask;
        }
    }
}
