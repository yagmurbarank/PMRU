using AutoMapper;
using MediatR;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.CreateAvailability
{
    public class CreateAvailabilityCommandHandler : IRequestHandler<CreateAvailabilityCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateAvailabilityCommandHandler(IUnitOfWork unitOfWork) 
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateAvailabilityCommandRequest request, CancellationToken cancellationToken)
        {
            Availability availability = new(request.DoctorID, request.Day, request.StartTime, request.EndTime);

            await unitOfWork.GetWriteRepository<Availability>().CreateAsync(availability);

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
