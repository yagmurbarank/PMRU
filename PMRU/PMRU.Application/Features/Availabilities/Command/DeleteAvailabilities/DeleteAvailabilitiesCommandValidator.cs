using FluentValidation;
using PMRU.Application.Features.Availabilities.Command.DeleteAvailability;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.DeleteAvailabilities
{
    public class DeleteAvailabilitiesCommandValidator : AbstractValidator<DeleteAvailabilitiesCommandRequest>
    {
        public DeleteAvailabilitiesCommandValidator()
        {
            RuleFor(x => x.Ids)
            .NotEmpty()
                .ForEach(id => id.GreaterThan(0).WithName("Uygunluk"))
                .WithName("Uygunluklar");
        }
    }
}
