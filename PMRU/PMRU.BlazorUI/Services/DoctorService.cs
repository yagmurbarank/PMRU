using AutoMapper;
using Blazored.LocalStorage;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Services.Base;
using static PMRU.BlazorUI.Services.DoctorServise;

namespace PMRU.BlazorUI.Services
{
    public class DoctorServise : BaseHttpService, IDoctorService
    {
        private readonly IMapper _mapper;
        public DoctorServise(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
            this._mapper = mapper;


        }
        public async Task<List<AppointmentVM>> GetAppointmentsByDoctorId(int doctorId)
        {
            var appointments = await _client.GetAppointmentsByDoctorIdAsync(doctorId);
            var mappedAppointments = _mapper.Map<List<AppointmentVM>>(appointments);
            return mappedAppointments;
        }
        public async Task<DoctorVM> GetDoctorById(int id)
        {
            var doctor = await _client.GetDoctorByIdAsync(id);
            var map = _mapper.Map<DoctorVM>(doctor);
            return map;
        }

        public async Task<List<DoctorVM>> GetDoctors()
        {
            var doctors = await _client.GetDoctorsAsync();
            var map = _mapper.Map<List<DoctorVM>>(doctors);
            return map;
        }

        internal interface IDoctorService
        {
        }

    }
}