using MediatR;
using Microsoft.AspNetCore.Http;
using PMRU.Application.Bases;
using PMRU.Application.Features.Doctors.Rules;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.RedisCache;
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
        private readonly IRedisCacheService redisCacheService;

        public CreateDoctorCommandHandler(DoctorRules doctorRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IRedisCacheService redisCacheService) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.doctorRules = doctorRules;
            this.redisCacheService = redisCacheService;

        }


        public async Task<Unit> Handle(CreateDoctorCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Doctor> doctors = await unitOfWork.GetReadRepository<Doctor>().GetAllAsync();
            await doctorRules.DoctorIdentityNumberMustNotBeSame(doctors, request.IdentityNumber, request.RegistrationNumber);

            Doctor doctor = new(request.IdentityNumber, request.RegistrationNumber, request.Name, request.Surname, request.Phone, request.Email, request.LocationID);

            await unitOfWork.GetWriteRepository<Doctor>().CreateAsync(doctor);
            await unitOfWork.SaveAsync();

            await redisCacheService.RemoveAsync($"GetDoctorById_{doctor.Id}");
            await redisCacheService.RemoveAsync($"GetDoctorByRegNo_{doctor.RegistrationNumber}");
            await redisCacheService.RemoveAsync($"GetDoctors_{DateTime.Now:yyyyMMddHHmm}");
            await redisCacheService.RemoveAsync($"GetDoctorByLocation_{doctor.LocationID}");

            return Unit.Value;
        }


    }
}
