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

namespace PMRU.Application.Features.Availabilities.Command.CreateAvailability
{
    public class CreateAvailabilityCommandHandler :BaseHandler, IRequestHandler<CreateAvailabilityCommandRequest, Unit>
    {
        private readonly AvailabilityRules availabilityRules;
        private readonly IRedisCacheService redisCacheService;

        public CreateAvailabilityCommandHandler(AvailabilityRules availabilityRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IRedisCacheService redisCacheService) : base(mapper, unitOfWork, httpContextAccessor) 
        {
            this.availabilityRules = availabilityRules;
            this.redisCacheService = redisCacheService;
        }

        public async Task<Unit> Handle(CreateAvailabilityCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Availability> availabilities = await unitOfWork.GetReadRepository<Availability>().GetAllAsync(x => !x.IsDeleted);

            await availabilityRules.DoctorCannotHaveAvailabilityAtTheSameTime(availabilities, request.DoctorID, request.Date, request.StartTime, request.EndTime);

            Availability availability = new(request.DoctorID, request.Date, request.StartTime, request.EndTime);

            await unitOfWork.GetWriteRepository<Availability>().CreateAsync(availability);

            await Task.WhenAll(
            redisCacheService.RemoveAsync($"GetAvailabilities_{DateTime.Now:yyyyMMddHHmm}"),
            redisCacheService.RemoveAsync($"GetAvailabilitiesByDay_{availability.Date.ToString("yyyyMMdd")}"),
            redisCacheService.RemoveAsync($"GetAvailabilityByDoctorId_{availability.DoctorID}"),
            redisCacheService.RemoveAsync($"GetAvailabilityByStartTime_{availability.StartTime.ToString("hhmmss")}"),
            redisCacheService.RemoveAsync($"GetAvailabilityById_{availability.Id}")
        );

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
