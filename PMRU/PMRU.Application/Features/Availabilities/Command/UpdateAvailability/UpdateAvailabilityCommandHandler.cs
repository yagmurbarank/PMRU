using MediatR;
using Microsoft.AspNetCore.Http;
using PMRU.Application.Bases;
using PMRU.Application.Features.Availabilities.Rules;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.RedisCache;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.UpdateAvailability
{
    public class UpdateAvailabilityCommandHandler :BaseHandler, IRequestHandler<UpdateAvailabilityCommandRequest, Unit>
    {
        private readonly AvailabilityRules availabilityRules;
        private readonly IRedisCacheService redisCacheService;

        public UpdateAvailabilityCommandHandler(AvailabilityRules availabilityRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IRedisCacheService redisCacheService) : base(mapper, unitOfWork, httpContextAccessor) 
        {
            this.availabilityRules = availabilityRules;
            this.redisCacheService = redisCacheService;
        }

        public async Task<Unit> Handle(UpdateAvailabilityCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Availability> availabilities = await unitOfWork.GetReadRepository<Availability>().GetAllAsync(x => !x.IsDeleted && x.Id != request.Id);

            await availabilityRules.DoctorCannotHaveAvailabilityAtTheSameTime(availabilities, request.DoctorID, request.Date, request.StartTime, request.EndTime);

            var availability = await unitOfWork.GetReadRepository<Availability>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<Availability, UpdateAvailabilityCommandRequest>(request);

            map.LastModifiedDate = DateTime.Now;

            await unitOfWork.GetWriteRepository<Availability>().UpdateAsync(map);
            await unitOfWork.SaveAsync();

            await Task.WhenAll(
            redisCacheService.RemoveAsync($"GetAvailabilities_{DateTime.Now:yyyyMMddHHmm}"),
            redisCacheService.RemoveAsync($"GetAvailabilitiesByDay_{request.Date.ToString("yyyyMMdd")}"),
            redisCacheService.RemoveAsync($"GetAvailabilityByDoctorId_{request.DoctorID}"),
            redisCacheService.RemoveAsync($"GetAvailabilityByStartTime_{request.StartTime.ToString("hhmmss")}"),
            redisCacheService.RemoveAsync($"GetAvailabilityById_{request.Id}")
            );

            return Unit.Value;
        }
    }
}
