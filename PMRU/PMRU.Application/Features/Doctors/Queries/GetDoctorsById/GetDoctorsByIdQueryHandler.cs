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

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorsById
{

    public class GetDoctorsByIdQueryHandler 
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetDoctorsByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetDoctorsByIdQueryResponse>> Handle(GetDoctorsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var doctors = await unitOfWork.GetReadRepository<Doctor>().GetAllAsync(predicate: x => x.Id == request.Id && !x.IsDeleted);
            var map = mapper.Map<GetDoctorsByIdQueryResponse, Doctor>(doctors);
            return map;
        }
    }
}
