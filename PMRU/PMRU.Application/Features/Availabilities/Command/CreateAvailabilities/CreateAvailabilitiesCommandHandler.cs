using MediatR;
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

        public CreateAvailabilitiesCommandHandler(IUnitOfWork unitOfWork) 
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateAvailabilitiesCommandRequest request, CancellationToken cancellationToken)
        {
            foreach (var availabilityRequest in request.AvailabilityRequests)
            {
                Availability availability = new(availabilityRequest.DoctorID, availabilityRequest.Day, availabilityRequest.StartTime, availabilityRequest.EndTime);
                await unitOfWork.GetWriteRepository<Availability>().CreateAsync(availability);
            }

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
