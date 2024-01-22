using AutoMapper;
using Blazored.LocalStorage;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Doctor;
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

        public async Task<Response<Guid>> DeleteDoctor(DeleteDoctorVM doctorVM) // calisiyor
        {
            try
            {
                DeleteDoctorCommandRequest deleteDoctorRequst = _mapper.Map<DeleteDoctorCommandRequest>(doctorVM);
                
                await _client.DeleteDoctorAsync(deleteDoctorRequst);
                return new Response<Guid>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<DoctorVM> GetDoctorById(int id) // calisiyor
        {
            var doctor = await _client.GetDoctorByIdAsync(id);
            var map = _mapper.Map<DoctorVM>(doctor);
            return map;
        }

        public async Task<DoctorVM> GetDoctorByRegistrationNumber(string registrationNumber)
        {
            var doctor = await _client.GetDoctorByRegistrationNumberAsync(registrationNumber);
            var mappedDoctor = _mapper.Map<DoctorVM>(doctor);
            return mappedDoctor;
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



  

        public async Task<Response<Guid>> UpdateDoctor(UpdateDoctorVM doctorVM) // calisiyor
        {
            try
            {
                UpdateDoctorCommandRequest request = _mapper.Map<UpdateDoctorCommandRequest>(doctorVM);
                await _client.UpdateDoctorAsync(request);
                return new Response<Guid> { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }
    }
}