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

namespace PMRU.BlazorUI.Pages.Availability
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
        [Inject]
        IJSRuntime jsInterop { get; set; }


        public List<DoctorVM> doctors { get; set; }
        public List<AvailabilityVM> availabilities { get; set; }
        private List<DoctorVM> doctorsInCurrentUserLocation;
        public EmployeeVM Employee { get; private set; } = new EmployeeVM();

        private Dictionary<int, bool> availabilityCheckboxes = new Dictionary<int, bool>();

        private AuthenticationState authenticationState;


        private int selectedDoctorId;
        bool selectAll = false;
        private bool isLoading = false;
        public string registrationNumber { get; set; } = "";



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

        private async Task GetAvailabilitiesByDoctorId()
        {
            isLoading = true;
            availabilities = await availabilityService.GetAvailabilitiesByDoctorId(selectedDoctorId);
            isLoading = false;
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

            await RefreshAvailabilities();

        }
        private async Task DeleteAvailabilities()
        {
            var selectedIds = availabilityCheckboxes.Where(kvp => kvp.Value).Select(kvp => kvp.Key).ToList();

            if (selectedIds.Any())
            {
                await availabilityService.DeleteAvailabilities(selectedIds);

                await RefreshAvailabilities();

                availabilityCheckboxes.Clear();
            }
            else
            {
                await jsInterop.InvokeVoidAsync("alert", "Lütfen en az bir öðe seçin.");
            }
        }

        private async Task ToggleSelectAll()
        {
            selectAll = !selectAll;
            SelectAll();
        }

        private void SelectAll()
        {
            foreach (var availability in availabilities)
            {
                availabilityCheckboxes[availability.Id] = selectAll;
            }
            StateHasChanged();
        }

        private async Task RefreshAvailabilities()
        {
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