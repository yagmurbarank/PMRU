using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMRU.Application.Features.Appointments.Queires.GetAppointments;
using PMRU.Application.Features.Availabilities.Command.UpdateAvailability;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilityById;
using PMRU.Application.Features.Doctors.Command.CreateDoctor;
using PMRU.Application.Features.Doctors.Command.DeleteDoctor;
using PMRU.Application.Features.Doctors.Command.UpdateDoctor;
using PMRU.Application.Features.Doctors.Queries.GetDoctorsByLocation;
using PMRU.Application.Features.Doctors.Queries.GetDoctors;
using PMRU.Application.Features.Doctors.Queries.GetDoctorById;
using AutoMapper.Features;
using PMRU.Application.Features.Doctors.Queries.GetDoctorsByLocation;
using PMRU.Domain.Entities;
using PMRU.Application.Features.Employees.Queries.GetEmployeesById;
using PMRU.Application.Features.Doctors.Queries.GetDoctorByRegistrationNumber;


namespace PMRU.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IMediator mediator;

        public DoctorController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IList<GetDoctorsQueryResponseDto>>> GetDoctors()
        {
            var response = await mediator.Send(new GetDoctorsQueryRequest());


            return Ok(response);
        }

        [HttpGet("{locationId}")]
        public async Task<ActionResult<IList<GetDoctorsByLocationQueryResponseDto>>> GetDoctorsByLocation(int locationId)
        {
            var request = new GetDoctorsByLocationQueryRequest(locationId);
           var response = await mediator.Send(request);

           return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<GetDoctorByIdQueryResponseDto>> GetDoctorById(int Id)
        {
            var request = new GetDoctorByIdQueryRequest(Id);
            var response = await mediator.Send(request);

            return Ok(response);
        }
        [HttpGet("{registrationNumber}")]
        public async Task<ActionResult<GetDoctorByRegistrationNumberQueryResponseDto>> GetDoctorByRegistrationNumber(string registrationNumber)
        {
            var request = new GetDoctorByRegistrationNumberQueryRequest(registrationNumber);
            var response = await mediator.Send(request);
            return Ok(response);
        }
        [HttpPost]
        public async Task<ActionResult> CreateDoctor(CreateDoctorCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> UpdateDoctor(UpdateDoctorCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteDoctor(DeleteDoctorCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok(response);
        }

    }
}