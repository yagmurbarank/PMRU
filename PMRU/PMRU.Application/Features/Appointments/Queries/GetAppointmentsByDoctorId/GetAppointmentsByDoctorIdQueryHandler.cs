using MediatR;
using Microsoft.EntityFrameworkCore;
using PMRU.Application.DTOs;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMRU.Application.Interfaces.AutoMapper;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentsByDoctorId
{
    public class GetAppointmentsByDoctorIdQueryHandler : IRequestHandler<GetAppointmentsByDoctorIdQueryRequest, IList<GetAppointmentsByDoctorIdQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAppointmentsByDoctorIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetAppointmentsByDoctorIdQueryResponse>> Handle(GetAppointmentsByDoctorIdQueryRequest request, CancellationToken cancellationToken)
        {
            var appointments = await unitOfWork.GetReadRepository<Appointment>()
               .GetAllAsync(predicate: x => x.DoctorID == request.DoctorId && !x.IsDeleted, include: x => x.Include(b => b.Employee));
            var employee = mapper.Map<EmployeeDto,Employee>(new Employee());

            var map = mapper.Map<GetAppointmentsByDoctorIdQueryResponse, Appointment>(appointments);
            return map;
        }
    }
}
