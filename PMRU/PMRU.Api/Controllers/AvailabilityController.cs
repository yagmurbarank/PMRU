using MediatR;
using Microsoft.AspNetCore.Authorization;
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
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByStartTime;
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
        [Authorize]
        public async Task<ActionResult<IList<GetAvailabilitiesQueryResponseDto>>> GetAvailabilities()
        {
            var response = await mediator.Send(new GetAvailabilitiesQueryRequest());

            return Ok(response);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<GetAvailabilityByIdQueryResponseDto>> GetAvailabilityById(int id)
        {
            var request = new GetAvailabilityByIdQueryRequest(id);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{doctorId}")]
        public async Task<ActionResult<IList<GetAvailabilitiesByDoctorIdQueryResponseDto>>> GetAvailabilitiesByDoctorId(int doctorId)
        {
            var request = new GetAvailabilitiesByDoctorIdQueryRequest(doctorId);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{date}")]
        [Authorize]
        public async Task<ActionResult<IList<GetAvailabilitiesByDayQueryResponseDto>>> GetAvailabilitiesByDay(DateOnly date)
        {
            var request = new GetAvailabilitiesByDayQueryRequest(date);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{startTime}")]
        [Authorize]
        public async Task<ActionResult<IList<GetAvailabilitiesByStartTimeQueryResponseDto>>> GetAvailabilitiesByStartTime(TimeOnly startTime)
        {
            var request = new GetAvailabilitiesByStartTimeQueryRequest(startTime);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> CreateAvailability(CreateAvailabilityCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> CreateAvailabilities(CreateAvailabilitiesCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> UpdateAvailability(UpdateAvailabilityCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> DeleteAvailability(DeleteAvailabilityCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> DeleteAvailabilities(DeleteAvailabilitiesCommandRequest request)
        {
            var response = await mediator.Send(request);

            return Ok();
        }
    }
}
