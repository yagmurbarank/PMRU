using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PMRU.Application.DTOs;
using PMRU.Application.Features.Doctors.Exceptions;
using PMRU.Application.Features.Doctors.Queries.GetDoctors;
using PMRU.Application.Features.Doctors.Queries.GetDoctorsByLocation;
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
    public class GetDoctorsByLocationQueryHandler /*: IRequestHandler<GetDoctorsByLocationQueryRequest, IList<GetDoctorsByLocationQueryResponse>>*/

    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetDoctorsByLocationQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetDoctorsByLocationQueryResponse>> Handle(GetDoctorsByLocationQueryRequest request, CancellationToken cancellationToken)
        {
            var doctors = await unitOfWork.GetReadRepository<Doctor>()
                .GetAllAsync(predicate: x => x.LocationID == request.LocationID && !x.IsDeleted);

            var map = mapper.Map<IEnumerable<Doctor>, IList<GetDoctorsByLocationQueryResponse>>(doctors);

            return map;
        }
        // public async Task<IList<GetDoctorsByLocationQueryResponse>> Handle(GetDoctorsByLocationQueryRequest request, CancellationToken cancellationToken)
        // {

        //var doctor = await unitOfWork.GetReadRepository<Location>().GetAllAsync(predicate: x => x.LocationID == request.LocationID && !x.IsDeleted);
        //var location = mapper.Map<DoctorDto, Doctor>(new Doctor());
        //var map = mapper.Map<GetDoctorsByLocationQueryResponse, Location>(doctor);
        //return doctor;

        // }

    }
}





