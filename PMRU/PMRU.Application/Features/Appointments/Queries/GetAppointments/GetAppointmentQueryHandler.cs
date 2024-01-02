using MediatR;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queires.GetAppointments
{
    public class GetAppointmentQueryHandler : IRequestHandler<GetAppointmentQueryRequest, IList<GetAppointmentQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAppointmentQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAppointmentQueryResponse>> Handle(GetAppointmentQueryRequest request, CancellationToken cancellationToken)
        {
            var appointments = await unitOfWork.GetReadRepository<Appointment>().GetAllAsync();

            List<GetAppointmentQueryResponse> response = new();

            foreach (var appointment in appointments)
            {
                response.Add(new GetAppointmentQueryResponse
                {
                    DoctorID = appointment.DoctorID,
                    EmployeeID = appointment.EmployeeID,
                    AppointmentDate = appointment.AppointmentDate,
                    AppointmentHour = appointment.AppointmentHour,
                    Description = appointment.Description,
                });
            }
            return response;
        }
    }
}