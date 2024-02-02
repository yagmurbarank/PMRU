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
using PMRU.BlazorUI.Models.Availability;
using PMRU.BlazorUI.Models.Doctor;
using PMRU.BlazorUI.Localization;

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
        public List<DoctorVM> doctors { get; set; }
        public List<AvailabilityVM> availabilities { get; set; }

        public string registrationNumber { get; set; } = "";
        public string messageTitle { get; set; }
        public string messageBody { get; set; }
        public string errorMessage { get; set; }

        protected async Task FindEmployee()
        {
            Reset();

            var response = await EmployeeService.GetEmployeeByRegistrationNumber(registrationNumber);
            if (response.Success)
            {
                Employee = response.Data;

                var result = await AppointmentService.GetAppointmentByEmployeeId(Employee.Id);

                if (result == null)
                {
                    doctors = await DoctorService.GetDoctorsByLocation(Employee.Location.Id);
                }
                else
                {
                    messageTitle = Loc[nameof(ResourceStrings.AppointmentsPageMessageTitle1)];
                    messageBody = string.Format(
                        Loc[nameof(ResourceStrings.AppointmentsPageMessageBody1)],
                        result.Doctor.Name,
                        result.Doctor.Surname,
                        result.AppointmentDate,
                        result.AppointmentStartHour,
                        result.AppointmentEndHour
                    );
                }
            }
            else
            {
                errorMessage = response.Message;
            }
        }

        protected async Task GetDoctorAvailabilities(int doctorId)
        {
            availabilities = await AvailabilityService.GetAvailabilitiesByDoctorId(doctorId);
        }

        protected async Task CreateAppointment(AvailabilityVM availability)
        {
            var appointment = new CreateAppointmentVM { EmployeeID = Employee.Id, DoctorID = availability.DoctorID, AppointmentDate = availability.Date, AppointmentStartHour = availability.StartTime, AppointmentEndHour = availability.EndTime, Description = "Periyodik Muayene" };
            var response = await AppointmentService.CreateAppointment(appointment);
            if (response.Success)
            {
                await AvailabilityService.DeleteAvailability(new DeleteAvailabilityVM { Id = availability.Id });
                doctors = null;
                availabilities = null;
                messageTitle = Loc[nameof(ResourceStrings.AppointmentsPageMessageTitle2)];
                messageBody = string.Format(
                    Loc[nameof(ResourceStrings.AppointmentsPageMessageBody2)],
                    availability.Doctor.Name,
                    availability.Doctor.Surname,
                    availability.Date,
                    availability.StartTime,
                    availability.EndTime
                );

            }
        }

        private void Reset()
        {
            Employee = new EmployeeVM();
            messageTitle = null;
            messageBody = null;
            errorMessage = null;
            doctors = null;
            availabilities = null;
        }
    }
}