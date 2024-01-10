using MediatR;
using PMRU.Application.Features.Doctors.Rules;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Command.CreateDoctor
{
    public class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly DoctorRules doctorRules;

        public CreateDoctorCommandHandler(IUnitOfWork unitOfWork, DoctorRules doctorRules)
        {
            this.unitOfWork = unitOfWork;
            this.doctorRules = doctorRules;

        }


        public async Task<Unit> Handle(CreateDoctorCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Doctor> doctors = await unitOfWork.GetReadRepository<Doctor>().GetAllAsync();
            await doctorRules.DoctorIdentityNumberMustNotBeSame(doctors, request.IdentityNumber);

            IList<Doctor> locations = await unitOfWork.GetReadRepository<Doctor>().GetAllAsync();
            await doctorRules.OneDoctorMustNotBeAtDifferentLocation(locations, request.LocationID);

            Doctor doctor = new(request.IdentityNumber, request.RegistrationNumber, request.Name, request.Surname, request.Phone, request.Email, request.Password, request.LocationID);

            await unitOfWork.GetWriteRepository<Doctor>().CreateAsync(doctor);

            await unitOfWork.SaveAsync();



            return Unit.Value;
        }


    }
}
