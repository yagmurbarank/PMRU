using AutoMapper;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Services
{
    public class EmployeeService : BaseHttpService, IEmployeeService
    {
        private readonly IMapper _mapper;

        public EmployeeService(IClient client, IMapper mapper) : base(client)
        {
            this._mapper = mapper;
        }

        public async Task<EmployeeVM> GetEmployeeByRegistrationNumber(string registrationNumber)
        {
            var employee = await _client.GetEmployeeByRegistrationNumberAsync(registrationNumber);
            var map = _mapper.Map<EmployeeVM>(employee);
            return map;
        }

        public async Task<List<EmployeeVM>> GetEmployees()
        {
            var employees = await _client.GetEmployeesAsync();
            var map = _mapper.Map<List<EmployeeVM>>(employees);
            return map;
        }
    }
}
