using MediatR;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Command.DeleteAppointment
{
    public class DeleteAppointmentCommandHandler : IRequestHandler<DeleteAppointmentCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteAppointmentCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(DeleteAppointmentCommandRequest request, CancellationToken cancellationToken)
        {
            var appointment = await unitOfWork.GetReadRepository<Appointment>().GetAsync(x=>x.Id == request.Id && !x.IsDeleted);
            appointment.IsDeleted = true;

            await unitOfWork.GetWriteRepository<Appointment>().UpdateAsync(appointment);
            await unitOfWork.SaveAsync();

            return Unit.Value;
            
        }
    }
}
