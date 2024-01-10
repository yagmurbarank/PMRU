using PMRU.Application.Bases;
using PMRU.Application.Features.Doctors.Exceptions;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Rules
{
    public class DoctorRules :BaseRules
    {
        public Task DoctorIdentityNumberMustNotBeSame(IList<Doctor> doctors,string requestIdentityNumber)
        {
            if (doctors.Any(x=>x.IdentityNumber==requestIdentityNumber)) throw new DoctorIdentityNumberMustNotBeSameException();
            return Task.CompletedTask;

        }
        public Task OneDoctorMustNotBeAtDifferentLocation(IList<Doctor> locationId, int requestLocationId)
        {
            if (locationId.Any(x => x.LocationID == requestLocationId)) throw new OneDoctorMustNotBeAtDifferentLocationException();
            return Task.CompletedTask;
        }
    }
}
