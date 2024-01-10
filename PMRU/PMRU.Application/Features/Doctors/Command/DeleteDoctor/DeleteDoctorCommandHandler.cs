using MediatR;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Command.DeleteDoctor
{
    public class DeleteDoctorCommandHandler : IRequestHandler<DeleteDoctorCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteDoctorCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(DeleteDoctorCommandRequest request, CancellationToken cancellationToken)
        {
            var doctor = await unitOfWork.GetReadRepository<Doctor>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            doctor.IsDeleted = true;
            doctor.DeletedDate = DateTime.Now;

            await unitOfWork.GetWriteRepository<Doctor>().UpdateAsync(doctor);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
