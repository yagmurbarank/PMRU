using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByDoctorId
{
    public class GetAvailabilitiesByDoctorIdQueryValidator : AbstractValidator<GetAvailabilitiesByDoctorIdQueryRequest>
    {
        public GetAvailabilitiesByDoctorIdQueryValidator()
        {
            RuleFor(x => x.DoctorId)
                .GreaterThan(0)
                .NotEmpty()
                .WithName("Doktor");
        }
    }
}
