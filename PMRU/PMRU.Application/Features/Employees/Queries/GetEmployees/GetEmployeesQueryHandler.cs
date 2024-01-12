using MediatR;
using Microsoft.EntityFrameworkCore;
using PMRU.Application.DTOs;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Employees.Queries.GetEmployees
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQueryRequest, IList<GetEmployeesQueryResponseDto>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetEmployeesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IList<GetEmployeesQueryResponseDto>> Handle(GetEmployeesQueryRequest request, CancellationToken cancellationToken)
        {
            var employees = await unitOfWork.GetReadRepository<Employee>().GetAllAsync(
                include: x => x
                    .Include(b => b.Department)
                    .Include(b => b.Location)
                    .Include(b => b.Position)
            );

            var departmentDto = mapper.Map<DepartmentDto, Department>(new Department());
            var locationDto = mapper.Map<LocationDto, Location>(new Location());
            var positionDto = mapper.Map<PositionDto, Position>(new Position());
            var map = mapper.Map<GetEmployeesQueryResponseDto, Employee>(employees);

            return map;
        }
    }
}
