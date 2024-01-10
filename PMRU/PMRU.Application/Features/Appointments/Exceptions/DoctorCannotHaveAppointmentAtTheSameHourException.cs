using PMRU.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Exceptions
{
    public class DoctorCannotHaveAppointmentAtTheSameHourException : BaseException
    {
        public DoctorCannotHaveAppointmentAtTheSameHourException() : base("Doktorun bu saatte zaten randevusu var!")
        {
            
        }
    }
}
