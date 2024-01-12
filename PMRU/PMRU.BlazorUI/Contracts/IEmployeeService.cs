using PMRU.BlazorUI.Models;

namespace PMRU.BlazorUI.Contracts
{
    public interface IEmployeeService
    {
        Task<List<EmployeeVM>> GetEmployees();
        Task<EmployeeVM> GetEmployeeByRegistrationNumber(string registrationNumber);
    }
}
