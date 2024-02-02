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

namespace PMRU.Application.Features.Availabilities.Command.CreateAvailabilities
{
    public class CreateAvailabilitiesCommandHandler :BaseHandler, IRequestHandler<CreateAvailabilitiesCommandRequest, Unit>
    {
        private readonly AvailabilityRules availabilityRules;
        private readonly IRedisCacheService redisCacheService;

        public CreateAvailabilitiesCommandHandler(AvailabilityRules availabilityRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IRedisCacheService redisCacheService) : base(mapper, unitOfWork, httpContextAccessor) 
        {
            this.availabilityRules = availabilityRules;
            this.redisCacheService = redisCacheService;
        }

        public async Task<Unit> Handle(CreateAvailabilitiesCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Availability> availabilities = await unitOfWork.GetReadRepository<Availability>().GetAllAsync(x => !x.IsDeleted);

            foreach (var availabilityRequest in request.AvailabilityRequests)
            {
                await availabilityRules.DoctorCannotHaveAvailabilityAtTheSameTime(availabilities, availabilityRequest.DoctorID, availabilityRequest.Date, availabilityRequest.StartTime, availabilityRequest.EndTime);

                Availability availability = new(availabilityRequest.DoctorID, availabilityRequest.Date, availabilityRequest.StartTime, availabilityRequest.EndTime);
                
                await unitOfWork.GetWriteRepository<Availability>().CreateAsync(availability);

                await redisCacheService.RemoveAsync($"GetAvailabilities_{DateTime.Now:yyyyMMddHHmm}");
                await redisCacheService.RemoveAsync($"GetAvailabilitiesByDay_{availability.Date.ToString("yyyyMMdd")}");
                await redisCacheService.RemoveAsync($"GetAvailabilityByDoctorId_{availability.DoctorID}");
                await redisCacheService.RemoveAsync($"GetAvailabilityByStartTime_{availability.StartTime.ToString("hhmmss")}");
                await redisCacheService.RemoveAsync($"GetAvailabilityById_{availability.Id}");
            }

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
