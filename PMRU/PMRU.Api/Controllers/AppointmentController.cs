﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using PMRU.Application.Features.Appointments.Queires.GetAppointments;
using PMRU.Application.Features.Appointments.Queries.GetAppointmentById;
using PMRU.Application.Features.Appointments.Queries.GetAppointmentsByDate;
using PMRU.Application.Features.Appointments.Queries.GetAppointmentsByDoctorId;
using PMRU.Application.Features.Appointments.Command.CreateAppointment;
using PMRU.Application.Features.Appointments.Command.UpdateAppointment;
using PMRU.Application.Features.Appointments.Command.DeleteAppointment;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilitiesByDay;

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
        public async Task<ActionResult<IList<GetAppointmentsQueryResponseDto>>> GetAppointments()
        {
            var response = await mediator.Send(new GetAppointmentsQueryRequest());

            return Ok(response);
        }

        [HttpGet("{doctorId}")]
        public async Task<ActionResult<IList<GetAppointmentsByDoctorIdQueryResponseDto>>> GetAppointmentsByDoctorId(int doctorId)
        {
            var request = new GetAppointmentsByDoctorIdQueryRequest(doctorId);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetAppointmentByIdQueryResponseDto>> GetAppointmentById(int id)
        {
            var request = new GetAppointmentByIdQueryRequest(id);
            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{date}")]
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
        public async Task<ActionResult> UpdateAppointment(UpdateAppointmentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> DeleteAppointment(DeleteAppointmentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}