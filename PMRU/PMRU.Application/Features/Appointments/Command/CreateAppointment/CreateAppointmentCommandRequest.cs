using MediatR;
using PMRU.Application.DTOs;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Command.CreateAppointment
{
    public class CreateAppointmentCommandRequest : IRequest<Unit>
    {
        public int EmployeeID { get; set; }
        public int DoctorID { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentStartHour { get; set; }
        public TimeOnly AppointmentEndHour { get; set; }
        public string Description { get; set; }
    }
}
