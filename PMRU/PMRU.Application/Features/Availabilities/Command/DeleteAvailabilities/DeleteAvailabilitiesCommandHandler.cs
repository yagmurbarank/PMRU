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

namespace PMRU.Application.Features.Availabilities.Command.DeleteAvailabilities
{
    public class DeleteAvailabilitiesCommandHandler : BaseHandler, IRequestHandler<DeleteAvailabilitiesCommandRequest, Unit>
    {
        private readonly IRedisCacheService redisCacheService;
        public DeleteAvailabilitiesCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IRedisCacheService redisCacheService) : base(mapper, unitOfWork, httpContextAccessor) 
        {
            this.redisCacheService = redisCacheService;
        }

        public async Task<Unit> Handle(DeleteAvailabilitiesCommandRequest request, CancellationToken cancellationToken)
        {
            List<Availability> availabilities = new();

            foreach (int id in request.Ids)
            {
                var availability = await unitOfWork.GetReadRepository<Availability>().GetAsync(x => x.Id == id && !x.IsDeleted);
                availability.IsDeleted = true;
                availability.DeletedDate = DateTime.Now;
                await unitOfWork.GetWriteRepository<Availability>().UpdateAsync(availability);
                await redisCacheService.RemoveAsync($"GetAvailabilityByDoctorId_{availability.DoctorID}");
            }

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
