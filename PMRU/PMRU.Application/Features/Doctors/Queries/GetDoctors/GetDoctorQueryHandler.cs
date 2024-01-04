using AutoMapper;
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
using IMapper = PMRU.Application.Interfaces.AutoMapper.IMapper;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctors
{
    public class GetDoctorQueryHandler : IRequestHandler<GetDoctorQueryRequest, IList<GetDoctorQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetDoctorQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetDoctorQueryResponse>> Handle(GetDoctorQueryRequest request, CancellationToken cancellationToken)
        {
            
            var Availabilities = await unitOfWork.GetReadRepository<Availability>().GetAllAsync(include: x => x.Include(b => b.Doctor));
            var doctors = await unitOfWork.GetReadRepository<Doctor>().GetAllAsync();
            var map = mapper.Map<GetDoctorQueryResponse, Doctor>(doctors);


            return map;
        }
    }
}
