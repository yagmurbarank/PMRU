using MediatR;
using Microsoft.AspNetCore.Mvc;
using PMRU.Application.Features.Appointments.Queires.GetAppointments;
using PMRU.Application.Features.Appointments.Queries.GetAppointmentById;
using PMRU.Application.Features.Appointments.Queries.GetAppointmentsByDate;
using PMRU.Application.Features.Appointments.Queries.GetAppointmentsByDoctorId;
using PMRU.Application.Features.Appointments.Command.CreateAppointment;
using PMRU.Application.Features.Appointments.Command.UpdateAppointment;
using PMRU.Application.Features.Appointments.Command.DeleteAppointment;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByDay;
using PMRU.Application.Features.Appointments.Queries.GetAppointmentByEmployeeId;
using Microsoft.AspNetCore.Authorization;

namespace PMRU.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IMediator mediator;

        public AppointmentController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IList<GetAppointmentsQueryResponseDto>>> GetAppointments()
        {
            var response = await mediator.Send(new GetAppointmentsQueryRequest());

            return Ok(response);
        }

        [HttpGet("{doctorId}")]
        [Authorize]
        public async Task<ActionResult<IList<GetAppointmentsByDoctorIdQueryResponseDto>>> GetAppointmentsByDoctorId(int doctorId)
        {
            var request = new GetAppointmentsByDoctorIdQueryRequest(doctorId);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{employeeId}")]
        public async Task<ActionResult<GetAppointmentByEmployeeIdQueryResponseDto>> GetAppointmentByEmployeeId(int employeeId)
        {
            var request = new GetAppointmentByEmployeeIdQueryRequest(employeeId);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<GetAppointmentByIdQueryResponseDto>> GetAppointmentById(int id)
        {
            var request = new GetAppointmentByIdQueryRequest(id);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{date}")]
        [Authorize]
        public async Task<ActionResult<IList<GetAppointmentsByDateQueryResponseDto>>> GetAppointmentsByDate(DateOnly date)
        {
            var request = new GetAppointmentsByDateQueryRequest(date);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAppointment(CreateAppointmentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> UpdateAppointment(UpdateAppointmentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> DeleteAppointment(DeleteAppointmentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}