using Microsoft.AspNetCore.Components;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Models.Availability;
using PMRU.BlazorUI.Models.Doctor;
using PMRU.BlazorUI.Services;
using PMRU.BlazorUI.Services.Base;
using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Pages.Authorization
{

    public partial class RoleManage
    {
        [Inject] IEmployeeService EmployeeService { get; set; }
        [Inject] IDoctorService DoctorService { get; set; }
        CreateDoctorVM doctor { get; set; } = new CreateDoctorVM();

        [Inject] IAuthenticationService AuthenticationService { get; set; }
        public EmployeeVM Employee { get; private set; } = new EmployeeVM();
        public string registrationNumber { get; set; } = "";
        public string role { get; set; } = "";
        public string password { get; set; } = "";
        public bool Disabled { get; set; } = false;
        public string messageTitle { get; set; }
        public string messageBody { get; set; }
        protected async Task FindEmployee()

        {
            var response = await EmployeeService.GetEmployeeByRegistrationNumber(registrationNumber);
            if (response.Success)
            {
                Employee = response.Data;
                Disabled = true;
            }
        }

        async Task GiveRole()
        {
            var fullName = Employee.Name + " " + Employee.Surname;
            var email = Employee.Email;
            var registrationNumber = Employee.RegistrationNumber;
            var password = this.password;
            var confirmPassword = this.password;
            var role = this.role;
            if (role == "doctor")
            {
                doctor.IdentityNumber = Employee.IdentityNumber;
                doctor.Name = Employee.Name;
                doctor.Surname = Employee.Surname;
                doctor.Phone = Employee.Phone.Substring(1, 3) + Employee.Phone.Substring(6, 3) + Employee.Phone.Substring(10, 4);
                doctor.Email = Employee.Email;
                doctor.LocationID = Employee.Location.Id;
                doctor.RegistrationNumber = Employee.RegistrationNumber;
                var response = await DoctorService.CreateDoctor(doctor);
            };
            var register = await AuthenticationService.RegisterAsync(fullName, email, password, confirmPassword, registrationNumber, role);
            if (register != null)
            {
                messageTitle = "Rol verme işlemi tamamlandı!";
                messageBody = $"{Employee.Name} {Employee.Surname} çalışanına {role.ToUpper()} rolü tanımlandı. Giriş bilgileri: EMail: {Employee.Email} Şifre:{password}";
            }
        }

    }
}
