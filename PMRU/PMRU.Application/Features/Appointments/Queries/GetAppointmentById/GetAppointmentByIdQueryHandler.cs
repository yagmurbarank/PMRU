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


namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentById
{
    public class GetAppointmentByIdQueryHandler : IRequestHandler<GetAppointmentByIdQueryRequest, IList<GetAppointmentByIdQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAppointmentByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper )
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetAppointmentByIdQueryResponse>> Handle(GetAppointmentByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var appointments = await unitOfWork.GetReadRepository<Appointment>()
                 .GetAllAsync(predicate: x => x.Id == request.Id && !x.IsDeleted, include: x => x.Include(b => b.Employee).Include(b=>b.Doctor));
            var employee = mapper.Map<EmployeeDto, Employee>(new Employee());
            var doctor = mapper.Map<DoctorDto, Doctor>(new Doctor());

            var map = mapper.Map<GetAppointmentByIdQueryResponse, Appointment>(appointments);
            return map;
        }
    }
}
