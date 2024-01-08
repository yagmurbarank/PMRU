using AutoMapper;
using MediatR;
using PMRU.Application.Features.Availabilities.Rules;
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
        private readonly AvailabilityRules availabilityRules;

        public CreateAvailabilityCommandHandler(IUnitOfWork unitOfWork, AvailabilityRules availabilityRules) 
        {
            this.unitOfWork = unitOfWork;
            this.availabilityRules = availabilityRules;
        }

        public async Task<Unit> Handle(CreateAvailabilityCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Availability> availabilities = await unitOfWork.GetReadRepository<Availability>().GetAllAsync(x => !x.IsDeleted);

            await availabilityRules.DoctorCannotHaveAvailabilityAtTheSameTime(availabilities, request.DoctorID, request.Day, request.StartTime, request.EndTime);

            Availability availability = new(request.DoctorID, request.Day, request.StartTime, request.EndTime);

            await unitOfWork.GetWriteRepository<Availability>().CreateAsync(availability);

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
