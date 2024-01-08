using FluentValidation;
using PMRU.Application.Features.Availabilities.Command.CreateAvailability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.CreateAvailabilities
{
    public class CreateAvailabilitiesCommandValidator : AbstractValidator<CreateAvailabilitiesCommandRequest>
    {
        public CreateAvailabilitiesCommandValidator()
        {
            RuleFor(x => x.AvailabilityRequests)
                .NotEmpty()
                .ForEach(item => item.SetValidator(new CreateAvailabilityCommandValidator()))
                .WithName("Uygunluklar");
        }
    }
}
