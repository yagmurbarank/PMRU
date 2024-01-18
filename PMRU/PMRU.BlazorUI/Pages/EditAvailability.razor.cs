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

        private AvailabilityVM availability;
        private List<DoctorVM> doctors;

        protected override async void OnInitialized()
        {

            var uri = new Uri(navigationManager.Uri);
            var lastSegment = uri.Segments.LastOrDefault();

            if (int.TryParse(lastSegment, out var id))
            {
                availabilityId = id;
            }
            availability = await availabilityService.GetAvailabilityById(availabilityId);//GetAvailabilityById test edilmeli.
        }

        private async Task UpdateAvailability()
        {
            // Güncelleme iþlemini yapmak için Mediator kullanabilirsin.
            // Örneðin: await Mediator.Send(new UpdateAvailabilityCommandRequest { Id = availability.Id, ... });

            // Güncelleme iþlemi tamamlandýktan sonra kullanýcýyý baþka bir sayfaya yönlendirebilirsin.
            // Örneðin: NavigationManager.NavigateTo("/availabilities");
        }
    }
}