using MediatR;
using PMRU.Application.Features.Appointments.Rules;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Command.CreateAppointment
{
    public class CreateAppointmentCommandHandler : IRequestHandler<CreateAppointmentCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly AppointmentRules appointmentRules;

        public CreateAppointmentCommandHandler(IUnitOfWork unitOfWork, AppointmentRules appointmentRules)
        {
            this.unitOfWork = unitOfWork;
            this.appointmentRules = appointmentRules;
        }
        public async Task<Unit> Handle(CreateAppointmentCommandRequest request, CancellationToken cancellationToken)
        {
            Appointment appointment = new(request.DoctorID, request.EmployeeID, request.AppointmentDate, request.AppointmentHour, request.Description);

            IList<Appointment> appointments = await unitOfWork.GetReadRepository<Appointment>().GetAllAsync();
            /*
            if (appointments.Any(x => x.AppointmentHour == request.AppointmentHour))
                throw new Exception("doktorun bu saatte randevusu bulunmakta");
            */

            await appointmentRules.DoctorCannotHaveAppointmentAtTheSameHour(appointments, request.DoctorID, request.AppointmentHour, request.AppointmentDate);
            

            await unitOfWork.GetWriteRepository<Appointment>().CreateAsync(appointment);
            await unitOfWork.SaveAsync();

            return Unit.Value;
            
        }
    }
}
