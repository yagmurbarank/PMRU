using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Contracts
{
    public interface IEmployeeService
    {
        Task<List<EmployeeVM>> GetEmployees();
        Task<Response<EmployeeVM>> GetEmployeeByRegistrationNumber(string registrationNumber);
    }
}
