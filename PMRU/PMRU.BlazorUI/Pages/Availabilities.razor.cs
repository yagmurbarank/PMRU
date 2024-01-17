using Microsoft.AspNetCore.Components;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models;
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


        protected override  async Task OnInitializedAsync()
        {
            availabilities = await availabilityService.GetAvailabilities();
        }


    }
}