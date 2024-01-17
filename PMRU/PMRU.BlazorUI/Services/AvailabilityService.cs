using AutoMapper;
using Blazored.LocalStorage;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Appointment;
using PMRU.BlazorUI.Models.Availability;
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
            var availabilities = await _client.GetAvailabilitiesAsync();
            var map = _mapper.Map<List<AvailabilityVM>>(availabilities);
            return map;
        }

        public async Task<Response<Guid>> CreateAvailability(CreateAvailabilityVM vm) // calisiyor
        {
            try
            {
                var response = new Response<Guid>();
                CreateAvailabilityCommandRequest createAvailabilityRequest = _mapper.Map<CreateAvailabilityCommandRequest>(vm);

                await _client.CreateAvailabilityAsync(createAvailabilityRequest);
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<Response<Guid>> CreateAvailabilities(List<CreateAvailabilityVM> vm) // calisiyor
        {
            try
            {
                var response = new Response<Guid>();
                List<CreateAvailabilityCommandRequest> createAvailabilities = _mapper.Map<List<CreateAvailabilityCommandRequest>>(vm);

                await _client.CreateAvailabilitiesAsync(new CreateAvailabilitiesCommandRequest { AvailabilityRequests = createAvailabilities });
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<Response<Guid>> DeleteAvailability(DeleteAvailabilityVM vm) // calisiyor
        {
            try
            {
                var response = new Response<Guid>();
                DeleteAvailabilityCommandRequest deleteAvailabilityRequest = _mapper.Map<DeleteAvailabilityCommandRequest>(vm);

                await _client.DeleteAvailabilityAsync(deleteAvailabilityRequest);
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<Response<Guid>> DeleteAvailabilities(List<int> ids) // calisiyor
        {
            try
            {
                var response = new Response<Guid>();

                await _client.DeleteAvailabilitiesAsync(new DeleteAvailabilitiesCommandRequest { Ids = ids });
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<Response<Guid>> UpdateAvailability(UpdateAvailabilityVM vm) // calisiyor
        {
            try
            {
                var response = new Response<Guid>();
                UpdateAvailabilityCommandRequest updateAvailabilityRequest = _mapper.Map<UpdateAvailabilityCommandRequest>(vm);

                await _client.UpdateAvailabilityAsync(updateAvailabilityRequest);
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }
    }
}
