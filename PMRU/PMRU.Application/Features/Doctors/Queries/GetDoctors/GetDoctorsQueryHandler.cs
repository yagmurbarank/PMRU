using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PMRU.Application.DTOs;
using PMRU.Application.Features.Appointments.Queires.GetAppointments;
using PMRU.Application.Features.Employees.Queries.GetEmployees;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using IMapper = PMRU.Application.Interfaces.AutoMapper.IMapper;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctors
{
    public class GetDoctorsQueryHandler : IRequestHandler<GetDoctorsQueryRequest, IList<GetDoctorsQueryResponseDto>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetDoctorsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetDoctorsQueryResponseDto>> Handle(GetDoctorsQueryRequest request, CancellationToken cancellationToken)
        {


            var doctors = await unitOfWork.GetReadRepository<Doctor>().GetAllAsync(include: x => x.Include(b => b.Location).Include(b => b.Availabilities));
            var location = mapper.Map<LocationDto, Location>(new Location());
            var availabilities = mapper.Map<AvailabilityDto, Availability>(new Availability());
            var map = mapper.Map<GetDoctorsQueryResponseDto, Doctor>(doctors);

            return map;
        }
    }
}
