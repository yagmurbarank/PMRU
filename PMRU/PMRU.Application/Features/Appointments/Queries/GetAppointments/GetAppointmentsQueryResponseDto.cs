using PMRU.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queires.GetAppointments
{
    public class GetAppointmentsQueryResponseDto
    {
        public int EmployeeID { get; set; }
        public EmployeeDto Employee { get; set; } = new EmployeeDto();
        public int DoctorID { get; set; }
        public DoctorDto Doctor { get; set; } = new DoctorDto();
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentHour { get; set; }
        public string Description { get; set; } = "general checkup";

    }
}