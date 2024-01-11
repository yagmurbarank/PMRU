using PMRU.Application.Bases;
using PMRU.Application.Features.Doctors.Exceptions;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Rules
{
    public class DoctorRules :BaseRules
    {
        public Task DoctorIdentityNumberMustNotBeSame(IList<Doctor> doctors,string requestIdentityNumber, string requestRegistrationNumber)
        {
            if (doctors.Any(x => x.IdentityNumber == requestIdentityNumber) || doctors.Any(y => y.RegistrationNumber == requestRegistrationNumber))
            {
                throw new DoctorIdentityNumberMustNotBeSameException();
            }
          
                return Task.CompletedTask;

        }
    
    }
}
