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
        public async Task<List<AvailabilityVM>> GetAvailabilitiesByDoctorId(int doctorId) // calisiyor
        {
            var availabilities = await _client.GetAvailabilitiesByDoctorIdAsync(doctorId);
            var mappedAvailabilities = _mapper.Map<List<AvailabilityVM>>(availabilities);
            return mappedAvailabilities;
        }

        public async Task<List<AvailabilityVM>> GetAvailabilities() // calisiyor
        {
            var availability = await _client.GetAvailabilitiesAsync();
            var map = _mapper.Map<List<AvailabilityVM>>(availability);
            return map;
        }

        public Task<Response<Guid>> CreateAvailability(AvailabilityVM vm)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Guid>> CreateAvailabilities(List<AvailabilityVM> vm)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Guid>> DeleteAvailability(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Guid>> DeleteAvailabilities(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Guid>> UpdateAvailability(AvailabilityVM vm)
        {
            throw new NotImplementedException();
        }
    }
}
