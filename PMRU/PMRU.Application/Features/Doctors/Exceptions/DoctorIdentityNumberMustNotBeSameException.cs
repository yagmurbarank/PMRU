using PMRU.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMRU.Domain.Entities;
namespace PMRU.Application.Features.Doctors.Exceptions
{
    public class DoctorIdentityNumberMustNotBeSameException : BaseException
    {
        public DoctorIdentityNumberMustNotBeSameException() : base("Bu doctor zaten kayıtlı!")
        {
           
            
        }
    }
}
