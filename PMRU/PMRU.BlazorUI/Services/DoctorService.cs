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

        public async Task<Response<Guid>> CreateDoctor(CreateDoctorVM doctorVM) // calisiyor
        {
            try
            {
                var response = new Response<Guid>();
                CreateDoctorCommandRequest createDoctorRequest = _mapper.Map<CreateDoctorCommandRequest>(doctorVM);

                await _client.CreateDoctorAsync(createDoctorRequest);
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public Task<Response<Guid>> DeleteDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<DoctorVM> GetDoctorById(int id) // calisiyor
        {
            var doctor = await _client.GetDoctorByIdAsync(id);
            var map = _mapper.Map<DoctorVM>(doctor);
            return map;
        }

        public async Task<List<DoctorVM>> GetDoctors() // calisiyor
        {
            var doctors = await _client.GetDoctorsAsync();
            var map = _mapper.Map<List<DoctorVM>>(doctors);
            return map;
        }

        public async Task<List<DoctorVM>> GetDoctorsByLocation(int locationid) // calisiyor
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