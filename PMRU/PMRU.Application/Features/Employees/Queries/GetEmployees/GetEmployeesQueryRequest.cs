﻿using MediatR;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Employees.Queries.GetEmployees
{
    public class GetEmployeesQueryRequest : IRequest<IList<GetEmployeesQueryResponseDto>> , ICacheableQuery
    {
        public string CacheKey => "GetAllEmployees";

        public double CacheTime => 1;
    }
}
