using MediatR;
using Microsoft.AspNetCore.Http;
using PMRU.Application.Bases;
using PMRU.Application.Features.Availabilities.Rules;
using PMRU.Application.Interfaces.AutoMapper;
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

        public CreateAvailabilitiesCommandHandler(AvailabilityRules availabilityRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor) 
        {
            this.availabilityRules = availabilityRules;
        }

        public async Task<Unit> Handle(CreateAvailabilitiesCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Availability> availabilities = await unitOfWork.GetReadRepository<Availability>().GetAllAsync(x => !x.IsDeleted);

            foreach (var availabilityRequest in request.AvailabilityRequests)
            {
                await availabilityRules.DoctorCannotHaveAvailabilityAtTheSameTime(availabilities, availabilityRequest.DoctorID, availabilityRequest.Date, availabilityRequest.StartTime, availabilityRequest.EndTime);

                Availability availability = new(availabilityRequest.DoctorID, availabilityRequest.Date, availabilityRequest.StartTime, availabilityRequest.EndTime);
                
                await unitOfWork.GetWriteRepository<Availability>().CreateAsync(availability);
            }

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
