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

            RuleFor(x => x.Date)
                .NotEmpty()
                .WithName("Gün");

            RuleFor(x => x.StartTime)
                .NotEmpty()
                .LessThan(x => x.EndTime)
                .WithName("Başlangıç Saati");

            RuleFor(x => x.EndTime)
                .NotEmpty()
                .GreaterThan(x => x.StartTime)
                .WithName("Bitiş Saati");
        }
    }
}
