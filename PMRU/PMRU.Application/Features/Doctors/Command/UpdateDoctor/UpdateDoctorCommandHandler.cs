using MediatR;
using PMRU.Application.Interfaces.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Features.Availabilities.Command.UpdateAvailability;
using PMRU.Domain.Entities;
using Microsoft.AspNetCore.Http;
using PMRU.Application.Bases;
using PMRU.Application.Interfaces.RedisCache;


namespace PMRU.Application.Features.Doctors.Command.UpdateDoctor
{

    public class UpdateDoctorCommandHandler :BaseHandler, IRequestHandler<UpdateDoctorCommandRequest>
    {
        private readonly IRedisCacheService redisCacheService;
        public UpdateDoctorCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IRedisCacheService redisCacheService) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.redisCacheService = redisCacheService;
        }

        public async Task<Unit> Handle(UpdateDoctorCommandRequest request, CancellationToken cancellationToken)
        {
            var doctor = await unitOfWork.GetReadRepository<Doctor>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            var map = mapper.Map<Doctor, UpdateDoctorCommandRequest>(request);


            await unitOfWork.GetWriteRepository<Doctor>().HardDeleteAsync(map);
           

            await unitOfWork.GetWriteRepository<Doctor>().AddAsync(map);
            await unitOfWork.GetWriteRepository<Doctor>().UpdateAsync(map);
            await unitOfWork.SaveAsync();

            await redisCacheService.RemoveAsync($"GetDoctorById_{request.Id}");
            await redisCacheService.RemoveAsync($"GetDoctorByRegNo_{request.RegistrationNumber}");
            await redisCacheService.RemoveAsync($"GetDoctors_{DateTime.Now:yyyyMMddHHmm}");
            await redisCacheService.RemoveAsync($"GetDoctorByLocation_{request.LocationID}");

            return Unit.Value;
        }
    }
}