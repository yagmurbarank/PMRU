using MediatR;
using Microsoft.EntityFrameworkCore;
using PMRU.Application.DTOs;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilities;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilityById
{
    public class GetAvailabilityByIdQueryHandler : IRequestHandler<GetAvailabilityByIdQueryRequest, GetAvailabilityByIdQueryResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAvailabilityByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) 
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<GetAvailabilityByIdQueryResponse> Handle(GetAvailabilityByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var availability = await unitOfWork.GetReadRepository<Availability>().GetAsync(predicate: x => x.Id == request.Id && !x.IsDeleted, include: x => x.Include(b => b.Doctor));
            var doctor = mapper.Map<DoctorDto, Doctor>(new Doctor());
            var map = mapper.Map<GetAvailabilityByIdQueryResponse, Availability>(availability);

            return map;
        }
    }
}
