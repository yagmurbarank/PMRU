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

namespace PMRU.Application.Features.Availabilities.Command.DeleteAvailability
{
    public class DeleteAvailabilityCommandHandler :BaseHandler, IRequestHandler<DeleteAvailabilityCommandRequest, Unit>
    {
        private readonly IRedisCacheService redisCacheService;
        public DeleteAvailabilityCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IRedisCacheService redisCacheService) : base(mapper, unitOfWork, httpContextAccessor) 
        {
            this.redisCacheService = redisCacheService;
        }

        public async Task<Unit> Handle(DeleteAvailabilityCommandRequest request, CancellationToken cancellationToken)
        {
            var availability = await unitOfWork.GetReadRepository<Availability>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            if (availability != null)
            {
                availability.IsDeleted = true;
                availability.DeletedDate = DateTime.Now;

                await unitOfWork.GetWriteRepository<Availability>().UpdateAsync(availability);
                await unitOfWork.SaveAsync();


                await redisCacheService.RemoveAsync($"GetAvailabilityByDoctorId_{availability.DoctorID}");
            }
            return Unit.Value;
        }
    }
}
