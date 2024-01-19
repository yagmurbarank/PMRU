using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Exceptions
{
    public class DoctorNotFoundException : Exception
    {
        public DoctorNotFoundException() : base($"Bu sicil Numarası ile eşleşen doktor bulunamadı.")
        {
        }
    }
}
