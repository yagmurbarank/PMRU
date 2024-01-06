using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMRU.Application.Features.Appointments.Queires.GetAppointments;
using PMRU.Application.Features.Availabilities.Command.CreateAvailability;
using PMRU.Application.Features.Availabilities.Command.DeleteAvailabilities;
using PMRU.Application.Features.Availabilities.Command.DeleteAvailability;
using PMRU.Application.Features.Availabilities.Command.UpdateAvailability;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilities;

namespace PMRU.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AvailabilityController : ControllerBase
    {
        private readonly IMediator mediator;

        public AvailabilityController(IMediator mediator) 
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAvailabilities()
        {
            var response = await mediator.Send(new GetAvailabilitiesQueryRequest());

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAvailability(CreateAvailabilityCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAvailability(UpdateAvailabilityCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAvailability(DeleteAvailabilityCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAvailabilities(DeleteAvailabilitiesCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok(response);
        }
    }
}
