using MediatR;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Command.CreateDoctor
{
    public class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        public CreateDoctorCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }


        public async Task<Unit> Handle(CreateDoctorCommandRequest request, CancellationToken cancellationToken)
        {
            Doctor doctor = new(request.IdentityNumber, request.RegistrationNumber, request.Name, request.Surname, request.Phone, request.Email, request.Password, request.LocationID);

            await unitOfWork.GetWriteRepository<Doctor>().CreateAsync(doctor);

            await unitOfWork.SaveAsync();



            return Unit.Value;
        }


    }
}
