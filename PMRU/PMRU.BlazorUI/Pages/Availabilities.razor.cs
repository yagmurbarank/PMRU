using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Availability;
using PMRU.BlazorUI.Models.Doctor;
using PMRU.BlazorUI.Services;
using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Pages
{
    public partial class Availabilities
    {
        [Inject]
        public IAvailabilityService availabilityService { get; set; }
        [Inject]
        public IDoctorService doctorService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }

        private List<AvailabilityVM> availabilities;
        private List<PMRU.BlazorUI.Models.Doctor.DoctorVM> doctors;
        private int doctorId;
        private int selectedDoctorId;


        protected override async Task OnInitializedAsync()
        {
            await LoadDoctors();
            availabilities = await availabilityService.GetAvailabilities();
        }

        private async Task LoadDoctors()
        {
            doctors = await doctorService.GetDoctors();
        }

        private async Task GetAvailabilitiesByDoctorId()
        {
            availabilities = await availabilityService.GetAvailabilitiesByDoctorId(selectedDoctorId);
        }

        private async void DeleteAvailability(AvailabilityVM availability)
        {

                var deleteAvailabilityVM = new DeleteAvailabilityVM { Id = availability.Id };
                await availabilityService.DeleteAvailability(deleteAvailabilityVM);

                selectedDoctorId = GetSelectedDoctorId();

                availabilities = await availabilityService.GetAvailabilitiesByDoctorId(selectedDoctorId);
            
        }
        private int GetSelectedDoctorId()
        {
            return selectedDoctorId;
        }
        private void NavigateToCreateAvailability()
        {
            NavigationManager.NavigateTo("/create-availability");
        }

        private void NavigateToEditAvailability()
        {
            NavigationManager.NavigateTo("/edit-availability");
        }
    }
}