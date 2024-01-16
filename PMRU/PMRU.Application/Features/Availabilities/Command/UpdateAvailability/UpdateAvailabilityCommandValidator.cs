using FluentValidation;
using PMRU.Application.Features.Availabilities.Command.CreateAvailability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.UpdateAvailability
{
    public class UpdateAvailabilityCommandValidator : AbstractValidator<UpdateAvailabilityCommandRequest>
    {
        public UpdateAvailabilityCommandValidator()
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
