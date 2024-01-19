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
        CreateAvailabilitiesInRange createAvailabilitiesInRangeModel = new CreateAvailabilitiesInRange();
        List<DoctorVM> doctors { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            availabilityToCreate.Date = new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            createAvailabilitiesInRangeModel.StartDate = new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            createAvailabilitiesInRangeModel.EndDate = new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

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

        protected async Task CreateAvailabilitiesInRange()
        {
            List<CreateAvailabilityVM> availabilitiesToCreate = new List<CreateAvailabilityVM>();

            for (DateOnly currentDate = createAvailabilitiesInRangeModel.StartDate; currentDate <= createAvailabilitiesInRangeModel.EndDate; currentDate = currentDate.AddDays(1))
            {
                for (TimeOnly currentStartTime = createAvailabilitiesInRangeModel.StartTime; currentStartTime < createAvailabilitiesInRangeModel.EndTime; currentStartTime = currentStartTime.AddMinutes(createAvailabilitiesInRangeModel.Duration))
                {
                    var currentEndTime = currentStartTime.AddMinutes(createAvailabilitiesInRangeModel.Duration);
                    if (currentEndTime > createAvailabilitiesInRangeModel.EndTime)
                    {
                        continue;
                    }
                    availabilitiesToCreate.Add(new CreateAvailabilityVM { DoctorID = createAvailabilitiesInRangeModel.DoctorID, Date = currentDate, StartTime = currentStartTime, EndTime = currentEndTime });
                }
            }

            var result = await AvailabilityService.CreateAvailabilities(availabilitiesToCreate);
            navigationManager.NavigateTo("availabilities");
        }

    }
}
