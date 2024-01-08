using MediatR;
using PMRU.Application.Features.Availabilities.Rules;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.UpdateAvailability
{
    public class UpdateAvailabilityCommandHandler : IRequestHandler<UpdateAvailabilityCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly AvailabilityRules availabilityRules;

        public UpdateAvailabilityCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, AvailabilityRules availabilityRules) 
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.availabilityRules = availabilityRules;
        }

        public async Task<Unit> Handle(UpdateAvailabilityCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Availability> availabilities = await unitOfWork.GetReadRepository<Availability>().GetAllAsync(x => !x.IsDeleted);

            await availabilityRules.DoctorCannotHaveAvailabilityAtTheSameTime(availabilities, request.DoctorID, request.Day, request.StartTime, request.EndTime);

            var availability = await unitOfWork.GetReadRepository<Availability>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<Availability, UpdateAvailabilityCommandRequest>(request);

            map.LastModifiedDate = DateTime.Now;

            await unitOfWork.GetWriteRepository<Availability>().UpdateAsync(map);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
