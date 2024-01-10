using PMRU.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Exceptions
{
    public class OneDoctorMustNotBeAtDifferentLocationException : BaseException
    {
        public OneDoctorMustNotBeAtDifferentLocationException() : base("Doktorun birden lokasyonu olamaz!") { }

    }
}
