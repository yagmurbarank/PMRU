using Microsoft.AspNetCore.Components;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Availability;
using PMRU.BlazorUI.Services;

namespace PMRU.BlazorUI.Pages
{
    public partial class Availabilities
    {
        [Inject]
        public IAvailabilityService availabilityService { get; set; }
        [Inject]
        public IDoctorService doctorService { get; set; }

        private List<AvailabilityVM> availabilities;
        private int doctorId;


        protected override  async Task OnInitializedAsync()
        {
            availabilities = await availabilityService.GetAvailabilities();
        }

        private async Task GetAvailabilitiesByDoctorId()
        {
            availabilities = await availabilityService.GetAvailabilitiesByDoctorId(doctorId);
        }


    }
}