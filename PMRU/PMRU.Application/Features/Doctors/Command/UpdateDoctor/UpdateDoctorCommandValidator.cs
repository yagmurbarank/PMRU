using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Command.UpdateDoctor
{
    public class UpdateDoctorCommandValidator: AbstractValidator<UpdateDoctorCommandRequest>
    {
        public UpdateDoctorCommandValidator()
        {
            RuleFor(x => x.Id)
               .GreaterThan(0);
             
            RuleFor(x => x.IdentityNumber)
              .NotEmpty()
              .WithName("TC Kimlik No");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithName("Ad");

            RuleFor(x => x.Surname)
                .NotEmpty()
                .WithName("Soyisim");

            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithName("Telefon Numarası");

            RuleFor(x => x.Email)
              .NotEmpty()
              .WithName("E-posta Adresi");

            RuleFor(x => x.LocationID)
               .GreaterThan(0)
              .NotEmpty()
              .WithName("E-posta Adresi");

            RuleFor(x => x.RegistrationNumber)
             .NotEmpty()
             .WithName("Sicil No");
        }
    }
}
