using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMRU.Application.Features.Appointments.Queires.GetAppointments;
using PMRU.Application.Features.Availabilities.Command.CreateAvailabilities;
using PMRU.Application.Features.Availabilities.Command.CreateAvailability;
using PMRU.Application.Features.Availabilities.Command.DeleteAvailabilities;
using PMRU.Application.Features.Availabilities.Command.DeleteAvailability;
using PMRU.Application.Features.Availabilities.Command.UpdateAvailability;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilities;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByDay;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByDoctorId;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilityById;

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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAvailabilityById(int id)
        {
            var request = new GetAvailabilityByIdQueryRequest(id);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{doctorId}")]
        public async Task<IActionResult> GetAvailabilitiesByDoctorId(int doctorId)
        {
            var request = new GetAvailabilitiesByDoctorIdQueryRequest(doctorId);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{day}")]
        public async Task<IActionResult> GetAvailabilitiesByDay(DayOfWeek day)
        {
            var request = new GetAvailabilitiesByDayQueryRequest(day);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAvailability(CreateAvailabilityCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAvailabilities(CreateAvailabilitiesCommandRequest request)
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
