using MediatR;
using Microsoft.AspNetCore.Http;
using PMRU.Application.Bases;
using PMRU.Application.Features.Appointments.Rules;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.RedisCache;
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

        private readonly IRedisCacheService redisCacheService;
        private readonly AppointmentRules appointmentRules;

        public UpdateAppointmentCommandHandler(AppointmentRules appointmentRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.appointmentRules = appointmentRules;
            this.redisCacheService = redisCacheService;
        }
        public async Task<Unit> Handle(UpdateAppointmentCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Appointment> appointments = await unitOfWork.GetReadRepository<Appointment>().GetAllAsync(x => !x.IsDeleted && x.Id != request.Id);
            await appointmentRules.DoctorCannotHaveAppointmentAtTheSameHour(appointments, request.DoctorID, request.AppointmentStartHour, request.AppointmentDate);
            var appointment = await unitOfWork.GetReadRepository<Appointment>().GetAsync(x=>x.Id==request.Id && !x.IsDeleted);
            var map = mapper.Map<Appointment,UpdateAppointmentCommandRequest>(request);
            map.AppointmentDate = request.AppointmentDate;
            map.AppointmentStartHour = request.AppointmentStartHour;
            map.AppointmentEndHour = request.AppointmentEndHour;

            await unitOfWork.GetWriteRepository<Appointment>().UpdateAsync(map);
            await unitOfWork.SaveAsync();

            await Task.WhenAll(
               redisCacheService.RemoveAsync($"GetAppointmentsByEmployeeId_{appointment.EmployeeID}"),
               redisCacheService.RemoveAsync($"GetAppointmentById_{appointment.Id}"),
               redisCacheService.RemoveAsync($"GetAppointments_{DateTime.Now:yyyyMMddHHmm}"),
               redisCacheService.RemoveAsync($"GetAppointmentsByDate_{request.AppointmentDate.ToString("yyyyMMdd")}"),
               redisCacheService.RemoveAsync($"GetAppointmentsByDoctorId_{appointment.DoctorID}")
               );

            return Unit.Value;
        }
    }
}
