using FluentValidation;
using PMRU.Application.Features.Availabilities.Command.UpdateAvailability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.DeleteAvailability
{
    public class DeleteAvailabilityCommandValidator : AbstractValidator<DeleteAvailabilityCommandRequest>
    {
        public DeleteAvailabilityCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .NotEmpty()
                .WithName("Uygunluk");
        }
    }
}
