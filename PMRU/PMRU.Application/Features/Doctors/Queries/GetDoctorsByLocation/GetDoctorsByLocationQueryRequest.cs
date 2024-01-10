

using MediatR;
using PMRU.Application.DTOs;
using PMRU.Application.Features.Employees.Queries.GetEmployeesById;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorByLocation
{
    public class GetDoctorByLocationQueryRequest : IRequest<IList<GetDoctorByLocationQueryResponse>>
    {

        public GetDoctorByLocationQueryRequest(string location)
        {
            Location = location;
       }

        public string Location { get; }

    }


}