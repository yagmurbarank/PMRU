using PMRU.Application.DTOs;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Employees.Queries.GetEmployeesById
{
    public class GetEmployeeByRegistrationNumberQueryResponseDto
    {
    public string IdentityNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string RegistrationNumber { get; set; }
    public DepartmentDto Department { get; set; }
    public LocationDto Location { get; set; }
    public PositionDto Position { get; set; }
    }
}
