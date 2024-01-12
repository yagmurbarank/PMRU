using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PMRU.Application.DTOs;
using PMRU.Application.Features.Doctors.Exceptions;
using PMRU.Application.Features.Doctors.Queries.GetDoctors;
using PMRU.Application.Features.Doctors.Queries.GetDoctorsByLocation;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorsByLocation
{
    public class GetDoctorsByLocationQueryHandler : IRequestHandler<GetDoctorsByLocationQueryRequest, IList<GetDoctorsByLocationQueryResponseDto>>

    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetDoctorsByLocationQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetDoctorsByLocationQueryResponseDto>> Handle(GetDoctorsByLocationQueryRequest request, CancellationToken cancellationToken)
        {
            var doctors = await unitOfWork.GetReadRepository<Doctor>().GetAllAsync(predicate: x => x.LocationID == request.LocationID && !x.IsDeleted, include: x => x.Include(b => b.Location).Include(b => b.Availabilities));
            var location = mapper.Map<LocationDto, Location>(new Location());
            var availabilities = mapper.Map<AvailabilityDto, Availability>(new Availability());
            var map = mapper.Map<GetDoctorsByLocationQueryResponseDto, Doctor>(doctors);

            return map;
        }

    }
}





