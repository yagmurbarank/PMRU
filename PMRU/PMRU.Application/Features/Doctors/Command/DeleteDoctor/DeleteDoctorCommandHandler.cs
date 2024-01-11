using MediatR;
using Microsoft.AspNetCore.Http;
using PMRU.Application.Bases;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Command.DeleteDoctor
{
    public class DeleteDoctorCommandHandler :BaseHandler, IRequestHandler<DeleteDoctorCommandRequest>
    {

        public DeleteDoctorCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
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
