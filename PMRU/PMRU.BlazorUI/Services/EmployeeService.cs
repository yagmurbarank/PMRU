using AutoMapper;
using Blazored.LocalStorage;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Models.Doctor;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Services
{
    public class EmployeeService : BaseHttpService, IEmployeeService
    {
        private readonly IMapper _mapper;

        public EmployeeService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
            this._mapper = mapper;
        }

        public async Task<Response<EmployeeVM>> GetEmployeeByRegistrationNumber(string registrationNumber) // calisiyor
        {
            
            try
            {
                var response = new Response<EmployeeVM>();

                var employee = await _client.GetEmployeeByRegistrationNumberAsync(registrationNumber);
                var map = _mapper.Map<EmployeeVM>(employee);
                response.Data = map;

                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<EmployeeVM>(ex);
            }
        }

        public async Task<List<EmployeeVM>> GetEmployees() // calisiyor
        {
            var employees = await _client.GetEmployeesAsync();
            var map = _mapper.Map<List<EmployeeVM>>(employees);
            return map;
        }
    }
}
