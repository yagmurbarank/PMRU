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
using PMRU.BlazorUI.Models.Appointment;

namespace PMRU.BlazorUI.Pages
{
    public partial class Appointments
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IDoctorService DoctorService { get; set; }
        [Inject]
        public IAvailabilityService AvailabilityService { get; set; }
        [Inject]
        public IAppointmentService AppointmentService { get; set; }

        public EmployeeVM Employee { get; private set; } = new EmployeeVM();

        public string registrationNumber { get; set; } = "";

        protected async Task FindEmployee()
        {
            Employee = await EmployeeService.GetEmployeeByRegistrationNumber(registrationNumber);

            //var doctors = await DoctorService.CreateDoctor(new CreateDoctorVM { IdentityNumber = "1234567891", Name = "John", Surname = "Doe", Phone = "1234567890", Email = "john@example.com", LocationID = 34, RegistrationNumber = "DR123", Password = "securepassword" });
            //var updatedoctors = await DoctorService.UpdateDoctor(new UpdateDoctorVM {Id=6, IdentityNumber = "0000000", Name = "John", Surname = "Doe", Phone = "1234567890", Email = "john@example.com", LocationID = 34, RegistrationNumber = "DR123", Password = "securepassword" });
            //var deletedoctor = await DoctorService.DeleteDoctor(new DeleteDoctorVM { Id=5});

            //var employees = await EmployeeService.GetEmployees();
            //var doctors = await DoctorService.CreateDoctor(new CreateDoctorVM { IdentityNumber = "123456789", Name = "John", Surname = "Doe", Phone = "1234567890", Email = "john@example.com", LocationID = 34, RegistrationNumber = "DR123", Password = "securepassword" });
            //var availabilities = await AvailabilityService.GetAvailabilitiesByDoctorId(1);

            //var deleteAppointment = await AppointmentService.DeleteAppointment(new DeleteAppointmentVM { Id = 5 });
            //var appointmemts = await AppointmentService.UpdateAppointment(new UpdateAppointmentVM { Id = 5, EmployeeID = 4, DoctorID = 2, AppointmentDate = new DateOnly(2024, 01, 17), AppointmentHour = new TimeOnly(15, 30), Description = "Routine checkup" });
        }
    }
}