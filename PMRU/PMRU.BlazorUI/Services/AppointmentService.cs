using AutoMapper;
using Blazored.LocalStorage;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Services
{
    public class AppointmentService : BaseHttpService, IAppointmentService
    {
        private readonly IMapper _mapper;

        public AppointmentService(IClient client,IMapper mapper , ILocalStorageService localStorage) : base(client, localStorage)
        {
            this._mapper = mapper;
        }

        public Task<Response<Guid>> CreateAppointment(AppointmentVM appointmentVM)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Guid>> DeleteAppointment(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AppointmentVM>> GetAppointments()
        {
            throw new NotImplementedException();
        }

        public Task<List<AppointmentVM>> GetAppoitmentsByDate(DateOnly date)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AppointmentVM>> GetAppoitmentsByDoctorId(int doctorId)
        {
            var appointments = await _client.GetAppointmentsByDoctorIdAsync(doctorId);
            var mappedAppointments = _mapper.Map<List<AppointmentVM>>(appointments);
            return mappedAppointments;
        }



        public Task<Response<Guid>> UpdateAppointment(AppointmentVM appointmentVM)
        {
            throw new NotImplementedException();
        }
    }
}
