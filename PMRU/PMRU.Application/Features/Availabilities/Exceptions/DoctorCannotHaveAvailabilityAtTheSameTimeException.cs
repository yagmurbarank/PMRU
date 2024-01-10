using PMRU.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Exceptions
{
    public class DoctorCannotHaveAvailabilityAtTheSameTimeException : BaseException
    {
        public DoctorCannotHaveAvailabilityAtTheSameTimeException() : base("Doktorun aynı saat aralığında uygunluğu zaten var!") { }
    }
}
