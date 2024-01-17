using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Command.CreateAppointment
{
    public class CreateAppointmentCommandValidator : AbstractValidator<CreateAppointmentCommandRequest>
    {
        public CreateAppointmentCommandValidator()
        {
            RuleFor(x=>x.EmployeeID)
                .NotEmpty()
                .GreaterThan(0)
                .WithName("Sicil No");

            RuleFor(x => x.DoctorID)
                .NotEmpty()
                .GreaterThan(0)
                .WithName("Doktor No");

            RuleFor(x => x.AppointmentDate)
                .NotEmpty()
                .WithName("Randevu Tarihi");

            RuleFor(x => x.AppointmentStartHour)
                .NotEmpty()
                .WithName("Randevu Başlangıç Saati");

            RuleFor(x=>x.Description)
                .NotEmpty()
                .WithName("Açıklama");
        }
    }
}
