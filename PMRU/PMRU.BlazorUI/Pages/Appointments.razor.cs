using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using PMRU.BlazorUI;
using PMRU.BlazorUI.Shared;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Contracts;
using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Pages
{
    public partial class Appointments
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IDoctorService DoctorService { get; set; }

        public EmployeeVM Employee { get; private set; } = new EmployeeVM();

        public string registrationNumber { get; set; } = "";

        protected async Task FindEmployee()
        {
            Employee = await EmployeeService.GetEmployeeByRegistrationNumber(registrationNumber);
            var doctors = await DoctorService.CreateDoctor(new CreateDoctorVM { IdentityNumber = "123456789", Name = "John", Surname = "Doe", Phone = "1234567890", Email = "john@example.com", LocationID = 34, RegistrationNumber = "DR123", Password = "securepassword" });
        }
    }
}