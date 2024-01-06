using MediatR;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Command.DeleteAvailabilities
{
    public class DeleteAvailabilitiesCommandHandler : IRequestHandler<DeleteAvailabilitiesCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteAvailabilitiesCommandHandler(IUnitOfWork unitOfWork) 
        {
            this.unitOfWork = unitOfWork;
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
            }

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
