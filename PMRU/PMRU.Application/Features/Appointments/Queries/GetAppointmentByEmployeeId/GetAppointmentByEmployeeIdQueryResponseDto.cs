using PMRU.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentByEmployeeId
{
    public class GetAppointmentByEmployeeIdQueryResponseDto
    {
        public int Id { get; set; }
        public DoctorDto Doctor { get; set; }
        public EmployeeDto Employee { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentStartHour { get; set; }
        public TimeOnly AppointmentEndHour { get; set; }
        public string Description { get; set; }
    }
}
