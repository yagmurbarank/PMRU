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
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQueryRequest, IList<GetEmployeesQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetEmployeesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IList<GetEmployeesQueryResponse>> Handle(GetEmployeesQueryRequest request, CancellationToken cancellationToken)
        {
            var employees = await unitOfWork.GetReadRepository<Employee>().GetAllAsync(include: x => x.Include(b => b.Department));
            var department = mapper.Map<DepartmentDto , Department>(new Department());
           
            //List<GetEmployeesQueryResponse> response = new();

            //foreach (var employee in employees) 
            
            //    response.Add(new GetEmployeesQueryResponse
            //    {
            //        IdentityNumber = employee.IdentityNumber,
            //        Name = employee.Name,
            //        Surname = employee.Surname,
            //        Phone = employee.Phone,
            //        Email = employee.Email,
            //        PositionID = employee.PositionID,
            //        LocationID = employee.LocationID,
            //        DepartmentID = employee.DepartmentID,
            //        RegistrationNumber = employee.RegistrationNumber,
            //    });

            var map = mapper.Map<GetEmployeesQueryResponse , Employee >(employees);

            return map;
            //return response;

        }
    }
}
