using MediatR;
using Microsoft.EntityFrameworkCore;
using PMRU.Application.DTOs;
using PMRU.Application.Features.Appointments.Queires.GetAppointments;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilities
{
    public class GetAvailabilitiesQueryHandler : IRequestHandler<GetAvailabilitiesQueryRequest, IList<GetAvailabilitiesQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAvailabilitiesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IList<GetAvailabilitiesQueryResponse>> Handle(GetAvailabilitiesQueryRequest request, CancellationToken cancellationToken)
        {
            var availabilities = await unitOfWork.GetReadRepository<Availability>().GetAllAsync(include: x => x.Include(b => b.Doctor));
            var doctor = mapper.Map<DoctorDto, Doctor>(new Doctor());
            var map = mapper.Map<GetAvailabilitiesQueryResponse, Availability>(availabilities);

            return map;
        }
    }
}
