using MediatR;
using PMRU.Application.Interfaces.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Features.Availabilities.Command.UpdateAvailability;
using PMRU.Domain.Entities;
using Microsoft.AspNetCore.Http;
using PMRU.Application.Bases;


namespace PMRU.Application.Features.Doctors.Command.UpdateDoctor
{

    public class UpdateDoctorCommandHandler :BaseHandler, IRequestHandler<UpdateDoctorCommandRequest>
    {

        public UpdateDoctorCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(UpdateDoctorCommandRequest request, CancellationToken cancellationToken)
        {
            var doctor = await unitOfWork.GetReadRepository<Doctor>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            var map = mapper.Map<Doctor, UpdateDoctorCommandRequest>(request);
            //map.Name = request.Name;
            //map.Surname = request.Surname;
            //map.IdentityNumber = request.IdentityNumber;
            //map.RegistrationNumber = request.RegistrationNumber;
            //map.LocationID = request.LocationID;

            await unitOfWork.GetWriteRepository<Doctor>().HardDeleteAsync(map);
           

            await unitOfWork.GetWriteRepository<Doctor>().AddAsync(map);
            await unitOfWork.GetWriteRepository<Doctor>().UpdateAsync(map);
            await unitOfWork.SaveAsync();


            //var map = mapper.Map<Doctor, UpdateDoctorCommandRequest>(request);

            //map.IdentityNumber = new Doctor() ;



            return Unit.Value;
        }
    }
}