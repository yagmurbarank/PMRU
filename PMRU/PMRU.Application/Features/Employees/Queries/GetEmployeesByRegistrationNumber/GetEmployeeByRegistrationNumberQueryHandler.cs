using MediatR;
using Microsoft.EntityFrameworkCore;
using PMRU.Application.DTOs;
using PMRU.Application.Features.Employees.Exceptions;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Employees.Queries.GetEmployeesById
{
    public class GetEmployeeByRegistrationNumberQueryHandler : IRequestHandler<GetEmployeeByRegistrationNumberQueryRequest, GetEmployeeByRegistrationNumberQueryResponseDto>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetEmployeeByRegistrationNumberQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<GetEmployeeByRegistrationNumberQueryResponseDto> Handle(GetEmployeeByRegistrationNumberQueryRequest request, CancellationToken cancellationToken)
        {
            var employee = await unitOfWork.GetReadRepository<Employee>()
                .GetAsync(predicate: x => x.RegistrationNumber == request.RegistrationNumber && !x.IsDeleted,
                          include: query => query.Include(e => e.Department)
                                                 .Include(e => e.Location)
                                                 .Include(e => e.Position)); ;
            if (employee == null)
            {
                throw new EmployeeNotFoundException();
            }
            var department = mapper.Map<DepartmentDto, Department>(employee.Department);
            var location = mapper.Map<LocationDto, Location>(employee.Location);
            var position = mapper.Map<PositionDto, Position>(employee.Position);
            var map = mapper.Map<GetEmployeeByRegistrationNumberQueryResponseDto, Employee>(employee);

            return map;
        }
    }
}
