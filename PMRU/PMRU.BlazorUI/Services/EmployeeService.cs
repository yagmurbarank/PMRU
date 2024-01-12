using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Services
{
    public class EmployeeService : BaseHttpService, IEmployeeService
    {
        public EmployeeService(IClient client) : base(client)
        {
        }
    }
}
