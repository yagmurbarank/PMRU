using MediatR;
using Microsoft.AspNetCore.Http;
using PMRU.Application.Bases;
using PMRU.Application.Features.Appointments.Rules;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Command.UpdateAppointment
{
    public class UpdateAppointmentCommandHandler :BaseHandler, IRequestHandler<UpdateAppointmentCommandRequest, Unit>
    {
        private readonly AppointmentRules appointmentRules;

        public UpdateAppointmentCommandHandler(AppointmentRules appointmentRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.appointmentRules = appointmentRules;
        }
        public async Task<Unit> Handle(UpdateAppointmentCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Appointment> appointments = await unitOfWork.GetReadRepository<Appointment>().GetAllAsync();
            await appointmentRules.DoctorCannotHaveAppointmentAtTheSameHour(appointments, request.DoctorID, request.AppointmentHour, request.AppointmentDate);
            var appointment = await unitOfWork.GetReadRepository<Appointment>().GetAsync(x=>x.Id==request.Id && !x.IsDeleted);
            var map = mapper.Map<Appointment,UpdateAppointmentCommandRequest>(request);
            map.AppointmentDate = request.AppointmentDate;
            map.AppointmentHour = request.AppointmentHour;
            
            await unitOfWork.GetWriteRepository<Appointment>().UpdateAsync(map);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
