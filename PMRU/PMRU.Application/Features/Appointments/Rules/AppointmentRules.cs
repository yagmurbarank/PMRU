using PMRU.Application.Bases;
using PMRU.Application.Features.Appointments.Exceptions;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Rules
{
    public class AppointmentRules : BaseRules
    {
        public Task DoctorCannotHaveAppointmentAtTheSameHour(IList<Appointment> appointments,int requestDoctorId, TimeOnly requestHour, DateOnly requestDate)
        {
            if (appointments.Any(x=>x.DoctorID == requestDoctorId) && appointments.Any(x=>x.AppointmentDate == requestDate) && appointments.Any(x=>x.AppointmentHour==requestHour)) throw new DoctorCannotHaveAppointmentAtTheSameHourException();
            
            return Task.CompletedTask;

        }
    }
}
