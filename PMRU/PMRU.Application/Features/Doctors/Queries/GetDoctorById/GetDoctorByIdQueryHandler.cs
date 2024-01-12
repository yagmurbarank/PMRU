using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMapper = PMRU.Application.Interfaces.AutoMapper.IMapper;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PMRU.Application.DTOs;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using PMRU.Application.Features.Doctors.Queries.GetDoctors;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorById
{

    public class GetDoctorByIdQueryHandler : IRequestHandler<GetDoctorByIdQueryRequest, GetDoctorByIdQueryResponseDto>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetDoctorByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<GetDoctorByIdQueryResponseDto> Handle(GetDoctorByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var doctors = await unitOfWork.GetReadRepository<Doctor>().GetAsync(predicate: x => x.Id == request.Id && !x.IsDeleted, include: x => x.Include(b => b.Location).Include(b => b.Availabilities));
            var location = mapper.Map<LocationDto, Location>(new Location());
            var availabilities = mapper.Map<AvailabilityDto, Availability>(new Availability());
            var map = mapper.Map<GetDoctorByIdQueryResponseDto, Doctor>(doctors);
            return map;
        }
    }
}
