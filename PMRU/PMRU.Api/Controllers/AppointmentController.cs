using MediatR;
using Microsoft.AspNetCore.Mvc;
using PMRU.Application.Features.Appointments.Queires.GetAppointments;
using PMRU.Application.Features.Appointments.Queries.GetAppointmentById;
using PMRU.Application.Features.Appointments.Queries.GetAppointmentByDate;
using PMRU.Application.Features.Appointments.Queries.GetAppointmentsByDoctorId;
using PMRU.Application.Features.Appointments.Command.CreateAppointment;
using PMRU.Application.Features.Appointments.Command.UpdateAppointment;
using PMRU.Application.Features.Appointments.Command.DeleteAppointment;

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
        public async Task<IActionResult> GetAppointment()
        {
            var response = await mediator.Send(new GetAppointmentQueryRequest());


            return Ok(response);
        }
        [HttpGet("{doctorId}")]
        public async Task<IActionResult> GetAppointmentsByDoctorId(int doctorId)
        {
            var request = new GetAppointmentsByDoctorIdQueryRequest(doctorId);
            var response = await mediator.Send(request);

            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppointmentByAId(int id)
        {
            var request = new GetAppointmentByIdQueryRequest(id);
            var response = await mediator.Send(request);

            return Ok(response);
        }
        [HttpGet("{date}")]
        public async Task<IActionResult> GetAppointmentByDate(DateOnly date)
        {
            var request = new GetAppointmentByDateQueryRequest(date);
            var response = await mediator.Send(request);

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAppointment(CreateAppointmentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAppointment(UpdateAppointmentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteAppointment(DeleteAppointmentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}