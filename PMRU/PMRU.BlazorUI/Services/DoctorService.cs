using AutoMapper;
using Blazored.LocalStorage;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Services.Base;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMRU.BlazorUI.Services
{
    public class DoctorService : BaseHttpService , IDoctorService
    {
        private readonly IMapper _mapper;
        

        public DoctorService(IClient client, IMapper mapper, Blazored.LocalStorage.ILocalStorageService localStorage) : base(client, localStorage)
        {
            this._mapper = mapper;
            
        }

        public async Task<Response<int>> CreateDoctor(CreateDoctorVM doctorVM)
        {
            try
            {
                var response = new Response<int>();
                var createDoctor = _mapper.Map<CreateDoctorCommandRequest>(doctorVM);
                AddBearerToken();
                var apiResponse = _client.CreateDoctorAsync(createDoctor);
                if (response.Success)
                {
                    response.Data = apiResponse.Id;
                    response.Success = true;
                }
                
                return response;
            }
            catch (ApiException exception)
            {
                return ConvertApiExceptions<int>(exception);
            }
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