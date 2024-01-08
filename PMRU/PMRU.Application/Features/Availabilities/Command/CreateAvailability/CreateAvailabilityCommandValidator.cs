using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.CreateAvailability
{
    public class CreateAvailabilityCommandValidator : AbstractValidator<CreateAvailabilityCommandRequest>
    {
        public CreateAvailabilityCommandValidator() 
        {
            RuleFor(x => x.DoctorID)
                .GreaterThan(0)
                .NotEmpty()
                .WithName("Doktor");

            RuleFor(x => x.Day)
                .NotEmpty()
                .WithName("Gün");

            RuleFor(x => x.StartTime)
                .NotEmpty()
                .WithName("Başlangıç Saati");

            RuleFor(x => x.EndTime)
                .NotEmpty()
                .WithName("Bitiş Saati");
        }
    }
}
