using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Employees.Queries.GetEmployeesById
{
    public class GetEmployeeByRegistrationNumberQueryValidator : AbstractValidator<GetEmployeeByRegistrationNumberQueryRequest>
    {
        public GetEmployeeByRegistrationNumberQueryValidator()
        {
            RuleFor(x => x.RegistrationNumber)
                .NotEmpty()
                .Matches("^[0-9]+$")
                .WithName("Sicil Numarası")
                .WithMessage("Sicil numarası sadece sayılardan oluşmalıdır.");
        }
    }
}
