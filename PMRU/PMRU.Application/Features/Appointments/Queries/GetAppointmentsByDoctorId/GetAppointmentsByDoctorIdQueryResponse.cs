using PMRU.Application.DTOs;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentsByDoctorId
{
    public class GetAppointmentsByDoctorIdQueryResponse
    {
        
        public int DoctorID { get; set; }
        public EmployeeDto Employee { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentHour { get; set; }
        public string Description { get; set; }

    }
}
