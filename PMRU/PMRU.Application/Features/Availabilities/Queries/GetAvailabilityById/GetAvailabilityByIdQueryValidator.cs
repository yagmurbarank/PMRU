using FluentValidation;
using PMRU.Application.Features.Availabilities.Command.CreateAvailability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilityById
{
    public class GetAvailabilityByIdQueryValidator : AbstractValidator<GetAvailabilityByIdQueryRequest>
    {
        public GetAvailabilityByIdQueryValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .NotEmpty()
                .WithName("Uygunluk");
        }
    }
}
