using MediatR;
using Microsoft.EntityFrameworkCore;
using PMRU.Application.DTOs;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentByEmployeeId
{
    public class GetAppointmentByEmployeeIdQueryHandler : IRequestHandler<GetAppointmentByEmployeeIdQueryRequest, GetAppointmentByEmployeeIdQueryResponseDto>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAppointmentByEmployeeIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<GetAppointmentByEmployeeIdQueryResponseDto> Handle(GetAppointmentByEmployeeIdQueryRequest request, CancellationToken cancellationToken)
        {
            var appointment = await unitOfWork.GetReadRepository<Appointment>()
                .GetAsync(predicate: x => x.EmployeeID == request.EmployeeId && !x.IsDeleted, include: x => x.Include(b => b.Employee).Include(b => b.Doctor));
            
            var employee = mapper.Map<EmployeeDto, Employee>(new Employee());
            var doctor = mapper.Map<DoctorDto, Doctor>(new Doctor());

            var map = mapper.Map<GetAppointmentByEmployeeIdQueryResponseDto, Appointment>(appointment);
            
            return map;
        }
    }
}
