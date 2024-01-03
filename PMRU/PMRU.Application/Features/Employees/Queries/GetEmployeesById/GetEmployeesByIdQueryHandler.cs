using MediatR;
using PMRU.Application.Interfaces.UnitOfWorks;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Employees.Queries.GetEmployeesById
{
    public class GetEmployeesByIdQueryHandler : IRequestHandler<GetEmployeesByIdQueryRequest, GetEmployeesByIdQueryResponse>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetEmployeesByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<GetEmployeesByIdQueryResponse> Handle(GetEmployeesByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var employee = await unitOfWork.GetReadRepository<Employee>().GetByIdAsync(request.EmployeeId);

            if (employee == null)
            {
                // Employee not found
                return null;
            }

            var response = new GetEmployeesByIdQueryResponse
            {
                IdentityNumber = employee.IdentityNumber,
                Name = employee.Name,
                Surname = employee.Surname,
                Phone = employee.Phone,
                Email = employee.Email,
                LocationID = employee.LocationID,
                PositionID = employee.PositionID,
                DepartmentID = employee.DepartmentID,
                RegistrationNumber = employee.RegistrationNumber,
            };

            return response;
        }
    }
}
