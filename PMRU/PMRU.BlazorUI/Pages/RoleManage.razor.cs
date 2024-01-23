using Microsoft.AspNetCore.Components;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Models.Doctor;
using PMRU.BlazorUI.Services;

namespace PMRU.BlazorUI.Pages
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
            if (role=="doctor") 
            {
                Createdoctor();
            };
            var register = await AuthenticationService.RegisterAsync(fullName, email, password, confirmPassword, registrationNumber, role);
        }
        async Task Createdoctor()
        {
            doctor.IdentityNumber = Employee.IdentityNumber;
            doctor.Name = Employee.Name;
            doctor.Surname = Employee.Surname;
            doctor.Phone = Employee.Phone.Substring(1,3)+Employee.Phone.Substring(6,3)+Employee.Phone.Substring(10,4);
            doctor.Email = Employee.Email;
            doctor.LocationID = Employee.Location.Id;
            doctor.RegistrationNumber = Employee.RegistrationNumber;
            doctor.Password = this.password;
            var response = await DoctorService.CreateDoctor(doctor);

        }
       
    }
}
