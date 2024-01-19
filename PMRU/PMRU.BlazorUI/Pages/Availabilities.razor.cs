using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Models.Availability;
using PMRU.BlazorUI.Models.Doctor;
using PMRU.BlazorUI.Services;
using PMRU.BlazorUI.Services.Base;
using PMRU.Domain.Entities;
using System.Security.Claims;

namespace PMRU.BlazorUI.Pages
{
    public partial class Availabilities
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IAvailabilityService availabilityService { get; set; }
        [Inject]
        public IDoctorService doctorService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        AuthenticationStateProvider authenticationStateProvider { get; set; }


        public List<DoctorVM> doctors { get; set; }
        public List<AvailabilityVM> availabilities { get; set; }
        public EmployeeVM Employee { get; private set; } = new EmployeeVM();

        private AuthenticationState authenticationState;

        private int doctorId;
        private int selectedDoctorId;
        public string registrationNumber { get; set; } = "";
        private List<DoctorVM> doctorsInCurrentUserLocation;


        protected override async Task OnInitializedAsync()
        {
            authenticationState = await authenticationStateProvider.GetAuthenticationStateAsync();

            if (authenticationState.User?.Claims != null)
            {
                var role = GetUserRole();

                if (role != null)
                {
                    if (role == "Doctor")
                    {
                        var registrationNumberClaim = authenticationState.User.Claims.FirstOrDefault(c => c.Type == "RegistrationNumber");
                        // Doktor ise sadece kendi bilgilerini getir
                        var doctor = await doctorService.GetDoctorByRegistrationNumber(registrationNumberClaim.Value);

                        if (doctor != null)
                        {
                            doctorsInCurrentUserLocation = new List<DoctorVM> { doctor };
                        }
                        else
                        {
                            doctorsInCurrentUserLocation = new List<DoctorVM>();
                        }
                    }
                    else
                    {
                        // Diðer roller için lokasyondaki tüm doktorlarý getir
                        var registrationNumberClaim = authenticationState.User.Claims.FirstOrDefault(c => c.Type == "RegistrationNumber");

                        if (registrationNumberClaim != null)
                        {
                            var employee = await EmployeeService.GetEmployeeByRegistrationNumber(registrationNumberClaim.Value);

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

        private async Task GetAvailabilitiesByDoctorId()
        {
            availabilities = await availabilityService.GetAvailabilitiesByDoctorId(selectedDoctorId);
        }

        private int GetSelectedDoctorId()
        {
            return selectedDoctorId;
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

        private async void DeleteAvailability(AvailabilityVM availability)
        {

                var deleteAvailabilityVM = new DeleteAvailabilityVM { Id = availability.Id };
                await availabilityService.DeleteAvailability(deleteAvailabilityVM);

                selectedDoctorId = GetSelectedDoctorId();

                availabilities = await availabilityService.GetAvailabilitiesByDoctorId(selectedDoctorId);
            
        }

        private void NavigateToCreateAvailability()
        {
            navigationManager.NavigateTo("/create-availability");
        }

        private void NavigateToEditAvailability(int availabilityId)
        {
            navigationManager.NavigateTo($"/edit-availability/{availabilityId}");
        }
    }
}