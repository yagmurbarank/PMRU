using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorsByLocation
{
    public class GetDoctorsByLocationQueryValidator: AbstractValidator<GetDoctorsByLocationQueryRequest>
    {
        public GetDoctorsByLocationQueryValidator()
        {
            RuleFor(x => x.LocationID)
                .GreaterThan(0)
                .NotEmpty()
                .WithName("Lokasyon");
        }
    }
}
