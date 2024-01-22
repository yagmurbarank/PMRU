using Microsoft.AspNetCore.Components;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models;

namespace PMRU.BlazorUI.Pages
{
    public partial class RoleManage
    {
        [Inject] IEmployeeService EmployeeService { get; set; }

        [Inject] IAuthenticationService AuthenticationService { get; set; }
        public EmployeeVM Employee { get; private set; } = new EmployeeVM();
        public string registrationNumber { get; set; } = "";
        public string role { get; set; } = "";
        public string password { get; set; } = "";
        public bool Disabled { get; set; } = false;
        protected async Task FindEmployee()
        {
            Employee = await EmployeeService.GetEmployeeByRegistrationNumber(registrationNumber);
            Disabled = true;
        }

         async Task GiveRole()
        {
            var fullName = Employee.Name + " " + Employee.Surname;
            var email = Employee.Email;
            var registrationNumber = Employee.RegistrationNumber;
            var password = this.password;
            var confirmPassword = this.password;
            var role = this.role;
            var register = await AuthenticationService.RegisterAsync(fullName, email, password, confirmPassword, registrationNumber, role);
        }
    }
}
