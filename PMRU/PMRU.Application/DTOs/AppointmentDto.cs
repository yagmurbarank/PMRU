using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.DTOs
{
    public class AppointmentDto
    {
        public DateTime AppointmentDate { get; set; }
        public string AppointmentHour { get; set; }
        public string Description { get; set; }
    }
}
