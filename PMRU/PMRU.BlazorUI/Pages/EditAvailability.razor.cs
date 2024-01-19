using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Availability;
using PMRU.BlazorUI.Models.Doctor;
using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Pages
{
    public partial class EditAvailability
    {
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        IAvailabilityService availabilityService { get; set; }

        [Parameter]
        public int availabilityId { get; set; }

        private AvailabilityVM availability = new AvailabilityVM();

        protected override async void OnInitialized()
        {

            var uri = new Uri(navigationManager.Uri);
            var lastSegment = uri.Segments.LastOrDefault();

            if (int.TryParse(lastSegment, out var id))
            {
                availabilityId = id;
            }
            availability = await availabilityService.GetAvailabilityById(availabilityId);
            StateHasChanged();
        }

        private async Task UpdateAvailability()
        {
            var uri = new Uri(navigationManager.Uri);
            var lastSegment = uri.Segments.LastOrDefault();

            if (int.TryParse(lastSegment, out var id))
            {
                availabilityId = id;
            }

            var existingAvailability = await availabilityService.GetAvailabilityById(availabilityId);


            var updateRequest = new UpdateAvailabilityVM
            {
                Id = existingAvailability.Id,
                DoctorID = existingAvailability.DoctorID,
                Date = availability.Date,
                StartTime = availability.StartTime,
                EndTime = availability.EndTime
            };

            var response = await availabilityService.UpdateAvailability(updateRequest);

            
            if (response.Success)
            {
                navigationManager.NavigateTo("/availabilities");
            }


        }
    }
}