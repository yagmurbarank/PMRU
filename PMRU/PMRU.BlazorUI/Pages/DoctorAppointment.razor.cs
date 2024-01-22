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
        private AuthenticationState authenticationState;
        private int doctorID;
        private string registrationNumber;
        private DoctorVM doctor { get; set; }
        protected override async Task OnInitializedAsync()
        {
            authenticationState = await authenticationStateProvider.GetAuthenticationStateAsync();

            if (authenticationState.User?.Claims != null)
            {
                var role = GetUserRole(); ;

                if (role != null)
                {
                    if (role == "Doctor")
                    {
                        var registrationNumberClaim = authenticationState.User.Claims.FirstOrDefault(c => c.Type == "RegistrationNumber");
                        var doctor = await doctorService.GetDoctorByRegistrationNumber(registrationNumberClaim.Value);

                        if (doctor != null)
                        {
                                 //Doktorun Id'sini almıyor
                                doctor.Id = doctorID;
                          

       
                            List<AppointmentVM> appointments = await appointmentService.GetAppointmentsByDoctorId(doctorID);
                        
                            
                        }
                        
                    }
                }
            }
        }

        private async Task GetAppointmentsByDoctorId(int doctorId)
        {
            appointments = await appointmentService.GetAppointmentsByDoctorId(doctorId);
        }

        private async Task GetDoctorByRegistrationNumber()
        {
            
            doctor = await doctorService.GetDoctorByRegistrationNumber(registrationNumber);

        
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
      
    }
}

