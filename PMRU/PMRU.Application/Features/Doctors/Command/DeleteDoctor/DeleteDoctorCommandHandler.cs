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

namespace PMRU.Application.Features.Doctors.Command.DeleteDoctor
{
    public class DeleteDoctorCommandHandler :BaseHandler, IRequestHandler<DeleteDoctorCommandRequest>
    {
        private readonly IRedisCacheService redisCacheService;

        public DeleteDoctorCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IRedisCacheService redisCacheService) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.redisCacheService = redisCacheService;
        }
        public async Task<Unit> Handle(DeleteDoctorCommandRequest request, CancellationToken cancellationToken)
        {
            var doctor = await unitOfWork.GetReadRepository<Doctor>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            doctor.IsDeleted = true;
            doctor.DeletedDate = DateTime.Now;

            await unitOfWork.GetWriteRepository<Doctor>().UpdateAsync(doctor);
            await unitOfWork.SaveAsync();

            await redisCacheService.RemoveAsync($"GetDoctorById_{doctor.Id}");
            await redisCacheService.RemoveAsync($"GetDoctorByRegNo_{doctor.RegistrationNumber}");
            await redisCacheService.RemoveAsync($"GetDoctors_{DateTime.Now:yyyyMMddHHmm}");
            await redisCacheService.RemoveAsync($"GetDoctorByLocation_{doctor.LocationID}");

            return Unit.Value;
        }
    }
}
