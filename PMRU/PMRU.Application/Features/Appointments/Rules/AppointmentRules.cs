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
            if (appointments.Any(x=>x.DoctorID == requestDoctorId && x.AppointmentDate == requestDate && x.AppointmentStartHour==requestHour)) throw new DoctorCannotHaveAppointmentAtTheSameHourException();
            
            return Task.CompletedTask;

        }

        public Task EmployeeCannotHaveMoreThanOneAppointment(IList<Appointment> appointments, int requestEmployeeId)
        {
            if (appointments.Any(x => x.EmployeeID == requestEmployeeId)) throw new EmployeeCannotHaveMoreThanOneAppoinmentException();

            return Task.CompletedTask;

        }
    }
}
