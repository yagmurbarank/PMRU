﻿using MediatR;
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

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentsByDate
{
    public class GetAppointmentsByDateQueryHandler : IRequestHandler<GetAppointmentsByDateQueryRequest, IList<GetAppointmentsByDateQueryResponseDto>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAppointmentsByDateQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetAppointmentsByDateQueryResponseDto>> Handle(GetAppointmentsByDateQueryRequest request, CancellationToken cancellationToken)
        {
            var appointments = await unitOfWork.GetReadRepository<Appointment>()
                 .GetAllAsync(predicate: x => x.AppointmentDate == request.Date && !x.IsDeleted, include: x => x.Include(b => b.Employee).Include(b => b.Doctor));
            var employee = mapper.Map<EmployeeDto, Employee>(new Employee());
            var doctor = mapper.Map<DoctorDto, Doctor>(new Doctor());

            var map = mapper.Map<GetAppointmentsByDateQueryResponseDto, Appointment>(appointments);
            return map;
        }
    }
}
