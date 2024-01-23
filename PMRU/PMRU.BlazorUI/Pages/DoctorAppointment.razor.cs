using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Appointment;
using PMRU.BlazorUI.Models.Doctor;
using PMRU.BlazorUI.Services;
using PMRU.Domain.Entities;
using System.Numerics;
using System.Security.Claims;


namespace PMRU.BlazorUI.Pages
{ 
    
    public partial class DoctorAppointment
    {
        [Inject]
        public IAppointmentService appointmentService { get; set; }
        [Inject]
        public IDoctorService doctorService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        AuthenticationStateProvider authenticationStateProvider { get; set; }
        private List<AppointmentVM> appointments { get; set; }
        private DoctorVM doctor { get; set; }

        private bool doctorLoaded = false;
        private bool appointmentsEmpty = false;




        protected override async Task OnInitializedAsync()
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            var authenticationState = await authenticationStateProvider.GetAuthenticationStateAsync();
            var role = GetUserRole(authenticationState);

            if (role == "Doctor")
            {
                var registrationNumberClaim = authenticationState.User.Claims.FirstOrDefault(c => c.Type == "RegistrationNumber");

                if (registrationNumberClaim != null)
                {
                    doctor = await doctorService.GetDoctorByRegistrationNumber(registrationNumberClaim.Value);

                    if (doctor != null)
                    {
                        appointments = await appointmentService.GetAppointmentsByDoctorId(doctor.Id);
                        StateHasChanged();
                        doctorLoaded = true;
                        appointmentsEmpty = appointments == null || !appointments.Any();
                    }
                }
            }
        }

        private string GetUserRole(AuthenticationState authenticationState)
        {
            if (authenticationState.User?.Identity?.IsAuthenticated == true)
            {
                var roleClaim = authenticationState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role);

                if (roleClaim != null)
                {
                    return roleClaim.Value;
                }
            }

            return null;
        }

        private async Task DeleteAppointment(int appointmentId)
        {
            var deleteAppointmentVM = new DeleteAppointmentVM
            {
                Id = appointmentId
            };

            var response = await appointmentService.DeleteAppointment(deleteAppointmentVM);

            if (response.Success)
            {
                
                Console.WriteLine("Appointment deleted successfully.");
                await LoadData();
            }

        }

        private void GoToReportPage()
        {
            navigationManager.NavigateTo("/reportpage");
        }

    }
}

