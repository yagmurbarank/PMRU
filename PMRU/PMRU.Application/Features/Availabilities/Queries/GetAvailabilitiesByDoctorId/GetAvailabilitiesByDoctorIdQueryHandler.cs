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

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByDoctorId
{
    public class GetAvailabilitiesByDoctorIdQueryHandler : IRequestHandler<GetAvailabilitiesByDoctorIdQueryRequest, IList<GetAvailabilitiesByDoctorIdQueryResponseDto>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAvailabilitiesByDoctorIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) 
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IList<GetAvailabilitiesByDoctorIdQueryResponseDto>> Handle(GetAvailabilitiesByDoctorIdQueryRequest request, CancellationToken cancellationToken)
        {
            var availabilities = await unitOfWork.GetReadRepository<Availability>().GetAllAsync(predicate: x => x.DoctorID == request.DoctorId && !x.IsDeleted, include: x => x.Include(b => b.Doctor));
            var doctor = mapper.Map<DoctorDto, Doctor>(new Doctor());
            var map = mapper.Map<GetAvailabilitiesByDoctorIdQueryResponseDto, Availability>(availabilities);

            return map;
        }
    }
}
