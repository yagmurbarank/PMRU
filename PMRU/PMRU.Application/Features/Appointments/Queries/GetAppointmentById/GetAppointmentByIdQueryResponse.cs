using PMRU.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentById
{
    public class GetAppointmentByIdQueryResponse
    {
        public DoctorDto Doctor {  get; set; }
        public EmployeeDto Employee { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentHour { get; set; }
        public string Description { get; set; }

    }
}
