using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorsById
{
    public class GetDoctorsByIdQueryValidator : AbstractValidator<GetDoctorsByIdQueryRequest>
    {
        public GetDoctorsByIdQueryValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .NotEmpty()
                .WithName("Doktor");
        }
    }
}
