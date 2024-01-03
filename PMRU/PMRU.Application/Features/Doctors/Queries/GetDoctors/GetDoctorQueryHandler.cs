using MediatR;
using PMRU.Application.Features.Appointments.Queires.GetAppointments;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctors
{
    public class GetDoctorQueryHandler : IRequestHandler<GetDoctorQueryRequest, IList<GetDoctorQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetDoctorQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IList<GetDoctorQueryResponse>> Handle(GetDoctorQueryRequest request, CancellationToken cancellationToken)
        {
            var doctors = await unitOfWork.GetReadRepository<Doctor>().GetAllAsync();

            List<GetDoctorQueryResponse> response = new();

            foreach (var doctor in doctors)
            {
                response.Add(new GetDoctorQueryResponse
                {
                    Name = doctor.Name,
                    Surname = doctor.Surname,
                    Location = doctor.Location,
                    Availabilities = doctor.Availabilities,
       

                });
            }
            return response;
        }
    }
}
