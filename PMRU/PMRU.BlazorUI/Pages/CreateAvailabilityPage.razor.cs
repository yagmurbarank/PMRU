using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Availability;
using PMRU.BlazorUI.Models.Doctor;
using PMRU.BlazorUI.Services;

namespace PMRU.BlazorUI.Pages
{
    public partial class CreateAvailabilityPage
    {
       
        [Inject]
        public IAvailabilityService AvailabilityService { get; set; }
        [Inject]
        public IDoctorService DoctorService { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        AuthenticationStateProvider authenticationStateProvider { get; set; }

        AuthenticationState authenticationState;

        CreateAvailabilityVM availabilityToCreate = new CreateAvailabilityVM();
        List<DoctorVM> doctors { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            authenticationState = await authenticationStateProvider.GetAuthenticationStateAsync();

            if (authenticationState.User?.Claims != null)
            {
                var registrationNumberClaim = authenticationState.User.Claims.FirstOrDefault(c => c.Type == "RegistrationNumber");
                if (registrationNumberClaim != null)
                {
                    var employee = await EmployeeService.GetEmployeeByRegistrationNumber(registrationNumberClaim.Value);

                    if (employee != null)
                    {
                        var location = employee.Location;
                        doctors = await DoctorService.GetDoctorsByLocation(location.Id);
                    }
                    else
                    {
                        doctors = new List<DoctorVM>();
                    }
                }
            }
        }

        protected async Task CreateAvailability()
        {
            var result = await AvailabilityService.CreateAvailability(this.availabilityToCreate);
            navigationManager.NavigateTo("availabilities");
        }

    }
}
