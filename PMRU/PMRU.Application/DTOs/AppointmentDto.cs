using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.DTOs
{
    public class AppointmentDto
    {
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentStartHour { get; set; }
        public TimeOnly AppointmentEndHour { get; set; }
        public string Description { get; set; }
    }
}
