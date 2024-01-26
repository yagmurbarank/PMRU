using MediatR;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Employees.Queries.GetEmployeesById
{
    public class GetEmployeeByRegistrationNumberQueryRequest : IRequest<GetEmployeeByRegistrationNumberQueryResponseDto>, ICacheableQuery
    {
        public GetEmployeeByRegistrationNumberQueryRequest(string registrationNumber) 
        {
            RegistrationNumber = registrationNumber;
        }

        public string RegistrationNumber { get; set; }

        public string CacheKey => $"GetEmployeeByRegNo_{RegistrationNumber}";

        public double CacheTime => 1;
    }
}
