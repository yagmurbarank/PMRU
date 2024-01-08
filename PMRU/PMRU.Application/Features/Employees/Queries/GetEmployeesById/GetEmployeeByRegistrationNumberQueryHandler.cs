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

namespace PMRU.Application.Features.Employees.Queries.GetEmployeesById
{
    public class GetEmployeeByRegistrationNumberQueryHandler : IRequestHandler<GetEmployeeByRegistrationNumberQueryRequest, GetEmployeeByRegistrationNumberQueryResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetEmployeeByRegistrationNumberQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<GetEmployeeByRegistrationNumberQueryResponse> Handle(GetEmployeeByRegistrationNumberQueryRequest request, CancellationToken cancellationToken)
        {
            var employee = await unitOfWork.GetReadRepository<Employee>()
                .GetAsync(x => x.RegistrationNumber == request.RegistrationNumber && !x.IsDeleted,
                          include: query => query.Include(e => e.Department)
                                                 .Include(e => e.Location)
                                                 .Include(e => e.Position));


            if (employee == null)
            {

                return null;
            }

            var response = new GetEmployeeByRegistrationNumberQueryResponse
            {
                IdentityNumber = employee.IdentityNumber,
                Name = employee.Name,
                Surname = employee.Surname,
                Phone = employee.Phone,
                Email = employee.Email,
                Department = mapper.Map<DepartmentDto, Department>(employee.Department),
                Location = mapper.Map<LocationDto, Location>(employee.Location),
                Position = mapper.Map<PositionDto, Position>(employee.Position),
                RegistrationNumber = employee.RegistrationNumber,
            };

            return response;
        }
    }
}
