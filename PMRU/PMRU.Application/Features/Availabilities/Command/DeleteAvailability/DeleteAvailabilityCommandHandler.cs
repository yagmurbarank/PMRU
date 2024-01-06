using MediatR;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.DeleteAvailability
{
    public class DeleteAvailabilityCommandHandler : IRequestHandler<DeleteAvailabilityCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteAvailabilityCommandHandler(IUnitOfWork unitOfWork) 
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteAvailabilityCommandRequest request, CancellationToken cancellationToken)
        {
            var availability = await unitOfWork.GetReadRepository<Availability>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            availability.IsDeleted = true;
            availability.DeletedDate = DateTime.Now;

            await unitOfWork.GetWriteRepository<Availability>().UpdateAsync(availability);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
