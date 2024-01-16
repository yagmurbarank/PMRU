using AutoMapper;
using Blazored.LocalStorage;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Services.Base;
using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Services
{
    public class AvailabilityService : BaseHttpService, IAvailabilityService
    {
        private readonly IMapper _mapper;
        public AvailabilityService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
            this._mapper = mapper;


        }
        public async Task<List<AvailabilityVM>> GetAvailabilitiesByDoctorId(int doctorId)
        {
            var availabilities = await _client.GetAvailabilitiesByDoctorIdAsync(doctorId);
            var mappedAvailabilities = _mapper.Map<List<AvailabilityVM>>(availabilities);
            return mappedAvailabilities;
        }
        //public async Task<AvailabilityVM> GetAvailabilityByDoctorId(int doctorId)
        //{
        //    var availability = await _client.GetAvailabilityByDoctorIdAsync(doctorId);
        //    var map = _mapper.Map<AvailabilityVM>(availability);
        //    return map;
        //}

        public async Task<List<AvailabilityVM>> GetAvailabilities()
        {
            var availability = await _client.GetAvailabilitiesAsync();
            var map = _mapper.Map<List<AvailabilityVM>>(availability);
            return map;
        }

        Task<List<Availability>> IAvailabilityService.GetAvailabilities()
        {
            throw new NotImplementedException();
        }

        public Task<AvailabilityVM> GetAvailabilitiesByDotorId(string doctorId)
        {
            throw new NotImplementedException();
        }

        public AvailabilityService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {

        }

       
    }
}
