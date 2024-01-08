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
        public DateTime AppointmentDate { get; set; }
        public string AppointmentHour { get; set; }
        public string Description { get; set; }

    }
}
