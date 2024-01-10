using MediatR;
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

        public CreateAppointmentCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CreateAppointmentCommandRequest request, CancellationToken cancellationToken)
        {
            Appointment appointment = new(request.DoctorID, request.EmployeeID, request.AppointmentDate, request.AppointmentHour, request.Description);

            await unitOfWork.GetWriteRepository<Appointment>().CreateAsync(appointment);
            await unitOfWork.SaveAsync();

            return Unit.Value;
            
        }
    }
}
