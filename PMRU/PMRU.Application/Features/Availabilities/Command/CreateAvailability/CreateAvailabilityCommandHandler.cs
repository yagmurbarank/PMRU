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

namespace PMRU.Application.Features.Availabilities.Command.CreateAvailability
{
    public class CreateAvailabilityCommandHandler :BaseHandler, IRequestHandler<CreateAvailabilityCommandRequest, Unit>
    {
        private readonly AvailabilityRules availabilityRules;

        public CreateAvailabilityCommandHandler(AvailabilityRules availabilityRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor) 
        {
            this.availabilityRules = availabilityRules;
        }

        public async Task<Unit> Handle(CreateAvailabilityCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Availability> availabilities = await unitOfWork.GetReadRepository<Availability>().GetAllAsync(x => !x.IsDeleted);

            await availabilityRules.DoctorCannotHaveAvailabilityAtTheSameTime(availabilities, request.DoctorID, request.Date, request.StartTime, request.EndTime);

            Availability availability = new(request.DoctorID, request.Date, request.StartTime, request.EndTime);

            await unitOfWork.GetWriteRepository<Availability>().CreateAsync(availability);

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
