using MediatR;
using Microsoft.AspNetCore.Http;
using PMRU.Application.Bases;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.RedisCache;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Command.DeleteAppointment
{
    public class DeleteAppointmentCommandHandler : BaseHandler, IRequestHandler<DeleteAppointmentCommandRequest,Unit>
    {
        private readonly IRedisCacheService redisCacheService;
        public DeleteAppointmentCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IRedisCacheService redisCacheService) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.redisCacheService = redisCacheService;
        }
        public async Task<Unit> Handle(DeleteAppointmentCommandRequest request, CancellationToken cancellationToken)
        {
            var appointment = await unitOfWork.GetReadRepository<Appointment>().GetAsync(x=>x.Id == request.Id && !x.IsDeleted);
            appointment.IsDeleted = true;
            appointment.DeletedDate = DateTime.Now;

            await unitOfWork.GetWriteRepository<Appointment>().UpdateAsync(appointment);
            await unitOfWork.GetWriteRepository<Appointment>().DeleteAsync(appointment);
            await unitOfWork.SaveAsync();

            await redisCacheService.RemoveAsync($"GetAppointmentsByDoctorId_{appointment.DoctorID}");
            await redisCacheService.RemoveAsync($"GetAppointmentsByEmployeeId_{appointment.EmployeeID}");
            await redisCacheService.RemoveAsync($"GetAppointmentsByDate_{appointment.AppointmentDate.ToString("yyyyMMdd")}");
            await redisCacheService.RemoveAsync($"GetAppointmentById_{appointment.Id}");
            await redisCacheService.RemoveAsync($"GetAppointments_{DateTime.Now:yyyyMMddHHmm}");

            return Unit.Value;
            
        }
    }
}
