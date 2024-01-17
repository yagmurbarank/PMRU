using AutoMapper;
using Blazored.LocalStorage;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Appointment;
using PMRU.BlazorUI.Models.Doctor;
using PMRU.BlazorUI.Pages;
using PMRU.BlazorUI.Services.Base;
using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Services
{
    public partial class AppointmentService : BaseHttpService, IAppointmentService
    {
        private readonly IMapper _mapper;

        public AppointmentService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
            this._mapper = mapper;
        }

        public async Task<List<AppointmentVM>> GetAppointmentsByDoctorId(int doctorId) // calisiyor
        {
            var appointments = await _client.GetAppointmentsByDoctorIdAsync(doctorId);
            var mappedAppointments = _mapper.Map<List<AppointmentVM>>(appointments);
            return mappedAppointments;
        }

        public async Task<List<AppointmentVM>> GetAppointments() // calisiyor
        {
            var appointment = await _client.GetAppointmentsAsync();
            var map = _mapper.Map<List<AppointmentVM>>(appointment);
            return map;
        }

        public async Task<List<AppointmentVM>> GetAppointmentsByDate(DateOnly date) // calisiyor
        {
            var map = _mapper.Map<DateTime>(date);
            var appointments = await _client.GetAppointmentsByDateAsync(map);
            var mappedAppointments = _mapper.Map<List<AppointmentVM>>(appointments);
            return mappedAppointments;
        }

        public async Task<Response<Guid>> CreateAppointment(CreateAppointmentVM appointmentVM) // calisiyor
        {
            try
            {
                var response = new Response<Guid>();
                CreateAppointmentCommandRequest createAppointmentRequest = _mapper.Map<CreateAppointmentCommandRequest>(appointmentVM);

                await _client.CreateAppointmentAsync(createAppointmentRequest);
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<Response<Guid>> DeleteAppointment(DeleteAppointmentVM appointmentVM) // calisiyor
        {
            try
            {
                var response = new Response<Guid>();
                DeleteAppointmentCommandRequest deleteAppointmentRequest = _mapper.Map<DeleteAppointmentCommandRequest>(appointmentVM);

                await _client.DeleteAppointmentAsync(deleteAppointmentRequest);
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }

        }

        public async Task<Response<Guid>> UpdateAppointment(UpdateAppointmentVM appointmentVM) // calisiyor
        {
            try
            {
                var response = new Response<Guid>();
                UpdateAppointmentCommandRequest updateAppointmentRequest = _mapper.Map<UpdateAppointmentCommandRequest>(appointmentVM);

                await _client.UpdateAppointmentAsync(updateAppointmentRequest);
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<AppointmentVM> GetAppointmentByEmployeeId(int employeeId)
        {
            try
            {
                var appointments = await _client.GetAppointmentByEmployeeIdAsync(employeeId);
                var mappedAppointments = _mapper.Map<AppointmentVM>(appointments);
                return mappedAppointments;
            }
            catch (ApiException ex)
            {
                return null;
            }
        }
    }
}


