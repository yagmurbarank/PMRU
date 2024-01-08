using MediatR;
using PMRU.Application.Features.Availabilities.Rules;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.CreateAvailabilities
{
    public class CreateAvailabilitiesCommandHandler : IRequestHandler<CreateAvailabilitiesCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly AvailabilityRules availabilityRules;

        public CreateAvailabilitiesCommandHandler(IUnitOfWork unitOfWork, AvailabilityRules availabilityRules) 
        {
            this.unitOfWork = unitOfWork;
            this.availabilityRules = availabilityRules;
        }

        public async Task<Unit> Handle(CreateAvailabilitiesCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Availability> availabilities = await unitOfWork.GetReadRepository<Availability>().GetAllAsync(x => !x.IsDeleted);

            foreach (var availabilityRequest in request.AvailabilityRequests)
            {
                await availabilityRules.DoctorCannotHaveAvailabilityAtTheSameTime(availabilities, availabilityRequest.DoctorID, availabilityRequest.Day, availabilityRequest.StartTime, availabilityRequest.EndTime);

                Availability availability = new(availabilityRequest.DoctorID, availabilityRequest.Day, availabilityRequest.StartTime, availabilityRequest.EndTime);
                
                await unitOfWork.GetWriteRepository<Availability>().CreateAsync(availability);
            }

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
