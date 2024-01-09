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
        public async Task<IActionResult> GetDoctor()
        {
            var response = await mediator.Send(new GetDoctorQueryRequest());


            return Ok(response);
        }
        [HttpGet("{location}")]
        public async Task<IActionResult> GetDoctorByLocation(int location)
        {
            var request = new GetDoctorQueryRequest(location);
            var response = await mediator.Send(request);

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDoctor(CreateDoctorCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateDoctor(UpdateDoctorCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteDoctor(DeleteDoctorCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok(response);
        }

    }
}