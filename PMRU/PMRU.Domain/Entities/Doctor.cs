using PMRU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Domain.Entities
{
    public class Doctor : Employee
    {
        public string Password { get; set; }

        // The doctor may have more than one appointment.
        public ICollection<Appointment> Appointments { get; set; }

        // Information on the day and time the doctor is available
        public ICollection<Availability> Availabilities { get; set; }
    }
}
