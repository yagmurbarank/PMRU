using FluentValidation;
using PMRU.Application.Features.Availabilities.Command.CreateAvailability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByStartTime
{
    public class GetAvailabilitiesByStartTimeQueryValidator : AbstractValidator<GetAvailabilitiesByStartTimeQueryRequest>
    {
        public GetAvailabilitiesByStartTimeQueryValidator()
        {
            RuleFor(x => x.StartTime)
                .NotEmpty()
                .WithName("Başlangıç Saati");
        }
    }
}
