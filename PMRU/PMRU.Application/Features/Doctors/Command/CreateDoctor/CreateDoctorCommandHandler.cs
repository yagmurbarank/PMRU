using MediatR;
using Microsoft.AspNetCore.Http;
using PMRU.Application.Bases;
using PMRU.Application.Features.Doctors.Rules;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Command.CreateDoctor
{
    public class CreateDoctorCommandHandler : BaseHandler, IRequestHandler<CreateDoctorCommandRequest, Unit>
    {
        private readonly DoctorRules doctorRules;

        public CreateDoctorCommandHandler(DoctorRules doctorRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
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
