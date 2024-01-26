using PMRU.Application.Interfaces.AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using PMRU.Application.Bases;
using PMRU.Application.Features.Appointments.Rules;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMRU.Application.Interfaces.RedisCache;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PMRU.Application.Features.Appointments.Command.CreateAppointment
{
    public class CreateAppointmentCommandHandler : BaseHandler, IRequestHandler<CreateAppointmentCommandRequest, Unit>
    {
        private readonly AppointmentRules appointmentRules;
        private readonly IRedisCacheService redisCacheService;

        public CreateAppointmentCommandHandler(AppointmentRules appointmentRules,IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IRedisCacheService redisCacheService) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.appointmentRules = appointmentRules;
            this.redisCacheService = redisCacheService;
        }
        public async Task<Unit> Handle(CreateAppointmentCommandRequest request, CancellationToken cancellationToken)
        {
            Appointment appointment = new(request.DoctorID, request.EmployeeID, request.AppointmentDate, request.AppointmentStartHour, request.AppointmentEndHour, request.Description);

            IList<Appointment> appointments = await unitOfWork.GetReadRepository<Appointment>().GetAllAsync(x => !x.IsDeleted);

            await appointmentRules.DoctorCannotHaveAppointmentAtTheSameHour(appointments, request.DoctorID, request.AppointmentStartHour, request.AppointmentDate);
            await appointmentRules.EmployeeCannotHaveMoreThanOneAppointment(appointments, request.EmployeeID);

            await unitOfWork.GetWriteRepository<Appointment>().CreateAsync(appointment);
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
