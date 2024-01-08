using FluentValidation;
using PMRU.Application.Features.Availabilities.Command.CreateAvailability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByDay
{
    public class GetAvailabilitiesByDayQueryValidator : AbstractValidator<GetAvailabilitiesByDayQueryRequest>
    {
        public GetAvailabilitiesByDayQueryValidator()
        {
            RuleFor(x => x.Day)
                .NotEmpty()
                .WithName("Gün");
        }
    }
}
