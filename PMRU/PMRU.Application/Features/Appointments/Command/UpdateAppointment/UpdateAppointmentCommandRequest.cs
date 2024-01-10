using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Command.UpdateAppointment
{
    public class UpdateAppointmentCommandRequest : IRequest<Unit>
    {
        
            public int Id { get; set; }
            public int EmployeeID { get; set; }
            public int DoctorID { get; set; }
            public DateOnly AppointmentDate { get; set; }
            public TimeOnly AppointmentHour { get; set; }
            public string Description { get; set; }
        
    }
}
