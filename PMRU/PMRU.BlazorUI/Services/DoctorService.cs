using AutoMapper;
using Blazored.LocalStorage;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Services.Base;
using PMRU.Domain.Entities;
using static PMRU.BlazorUI.Services.DoctorService;

namespace PMRU.BlazorUI.Services
{
    public class DoctorService : BaseHttpService , IDoctorService
    {
        private readonly IMapper _mapper;
        public DoctorService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
            this._mapper = mapper;
        }

        public Task<Response<Guid>> CreateDoctor(DoctorVM doctorVM)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Guid>> DeleteDoctor(int id)
        {
            throw new NotImplementedException();
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

        public async Task<List<DoctorVM>> GetDoctorsByLocation(int locationid)
        {
            var doctorsByLocation = await _client.GetDoctorsByLocationAsync(locationid);
            var mappedDoctors = _mapper.Map<List<DoctorVM>>(doctorsByLocation);
            return mappedDoctors;
        }

        public Task<Response<Guid>> UpdateDoctor(DoctorVM doctorVM)
        {
            throw new NotImplementedException();
        }
    }
}