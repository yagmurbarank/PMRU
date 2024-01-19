using MediatR;
using Microsoft.EntityFrameworkCore;
using PMRU.Application.DTOs;
using PMRU.Application.Features.Doctors.Exceptions;
using PMRU.Application.Features.Employees.Exceptions;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using IMapper = PMRU.Application.Interfaces.AutoMapper.IMapper;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorByRegistrationNumber
{
    public class GetDoctorByRegistrationNumberQueryHandler : IRequestHandler<GetDoctorByRegistrationNumberQueryRequest, GetDoctorByRegistrationNumberQueryResponseDto>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public GetDoctorByRegistrationNumberQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<GetDoctorByRegistrationNumberQueryResponseDto> Handle(GetDoctorByRegistrationNumberQueryRequest request, CancellationToken cancellationToken)
        {
            var doctor = await unitOfWork.GetReadRepository<Doctor>()
                  .GetAsync(predicate: x => x.RegistrationNumber == request.RegistrationNumber && !x.IsDeleted,
                            include: query => query.Include(e => e.Availabilities)
                                                   .Include(e => e.Appointments)
                                                   .Include(e => e.Location));
            if (doctor == null)
            {
                throw new DoctorNotFoundException();
            }
            var availability = mapper.Map<AvailabilityDto,Availability>(new Availability());
            var location = mapper.Map<LocationDto, Location>(new Location());
            var appointment = mapper.Map<AppointmentDto, Appointment>(new Appointment());

            var map = mapper.Map<GetDoctorByRegistrationNumberQueryResponseDto, Doctor>(doctor);

            return map;
        }
    }
}
