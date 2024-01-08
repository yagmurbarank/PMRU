using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByDoctorId;
using PMRU.Application.Features.Employees.Queries.GetEmployees;
using PMRU.Application.Features.Employees.Queries.GetEmployeesById;
using PMRU.Domain.Entities;

namespace PMRU.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator mediator;

        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeesById(GetEmployeesByIdQueryRequest request)
        {
            var response = await mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{registrationNumber}")]
        public async Task<IActionResult> GetEmployees(string registrationNumber)
        {
            var request = new GetEmployeesByIdQueryRequest(registrationNumber);
            var response = await mediator.Send(request);
            return Ok(response);
        }
    }
}
