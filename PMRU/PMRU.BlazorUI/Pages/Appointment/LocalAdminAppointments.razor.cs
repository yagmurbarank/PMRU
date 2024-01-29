using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Appointment;
using PMRU.BlazorUI.Models.Doctor;
using System.Security.Claims;

namespace PMRU.BlazorUI.Pages.Appointment
{
    public partial class LocalAdminAppointments
    {
        [Inject]
        public IDoctorService doctorService { get; set; }
        [Inject]
        public IAppointmentService appointmentService { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        AuthenticationStateProvider authenticationStateProvider { get; set; }

        private List<DoctorVM> doctorsInCurrentUserLocation;
        private List<AppointmentVM> appointments { get; set; }
        private DoctorVM doctor { get; set; }
        private AuthenticationState authenticationState;

        private bool appointmentsLoaded = false;
        private int selectedDoctorId;

        protected override async Task OnInitializedAsync()
        {
            authenticationState = await authenticationStateProvider.GetAuthenticationStateAsync();

            if (authenticationState.User?.Claims != null)
            {
                var role = GetUserRole();

                if (role != null)
                {
                    if (role == "LocalAdmin")
                    {
                        var registrationNumberClaim = authenticationState.User.Claims.FirstOrDefault(c => c.Type == "RegistrationNumber");

                        if (registrationNumberClaim != null)
                        {
                            var response = await EmployeeService.GetEmployeeByRegistrationNumber(registrationNumberClaim.Value);
                            if (response.Success)
                            {
                                var employee = response.Data;

                                if (employee != null)
                                {
                                    var location = employee.Location;
                                    doctorsInCurrentUserLocation = await doctorService.GetDoctorsByLocation(location.Id);
                                }
                                else
                                {
                                    doctorsInCurrentUserLocation = new List<DoctorVM>();
                                }
                            }
                        }
                    }
                }
            }
        }

        private string GetUserRole()
        {
            if (authenticationState.User?.Identity?.IsAuthenticated == true)
            {
                var roleClaim = authenticationState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role);
                if (roleClaim != null)
                { return roleClaim.Value; }
            }

            return null;
        }

        private async Task GetAppointments()
        {
            if (selectedDoctorId != 0)
            {
                appointments = await appointmentService.GetAppointmentsByDoctorId(selectedDoctorId);
                StateHasChanged();
                appointmentsLoaded = true;
            }
        }

        private void GoToReportPage()
        {
            navigationManager.NavigateTo("/reportpage");
        }
    }
}


