using MediatR;
using PMRU.Application.Features.Appointments.Queires.GetAppointments;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilities
{
    public class GetAvailabilitiesQueryHandler : IRequestHandler<GetAvailabilitiesQueryRequest, IList<GetAvailabilitiesQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAvailabilitiesQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IList<GetAvailabilitiesQueryResponse>> Handle(GetAvailabilitiesQueryRequest request, CancellationToken cancellationToken)
        {
            var availabilities = await unitOfWork.GetReadRepository<Availability>().GetAllAsync();

            List<GetAvailabilitiesQueryResponse> response = new();

            foreach (var availability in availabilities)
            {
                response.Add(new GetAvailabilitiesQueryResponse
                {
                    DoctorID = availability.DoctorID,
                    Day = availability.Day,
                    StartTime = availability.StartTime,
                    EndTime = availability.EndTime,
                });
            }

            return response;
        }
    }
}
