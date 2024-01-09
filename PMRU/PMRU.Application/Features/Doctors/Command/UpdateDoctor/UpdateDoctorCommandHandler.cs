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


namespace PMRU.Application.Features.Doctors.Command.UpdateDoctor
{

    public class UpdateDoctorCommandHandler : IRequestHandler<UpdateDoctorCommandRequest>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public UpdateDoctorCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

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