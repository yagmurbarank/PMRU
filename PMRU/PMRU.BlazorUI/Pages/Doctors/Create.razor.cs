using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Doctor;

namespace PMRU.BlazorUI.Pages.Doctors
{
    public partial class Create
    {
        /*[Inject] NavigationManager _navManager { get; set; }*/
        [Inject] IDoctorService _client { get; set; }
        /*[Inject] IToastService toastService { get; set; }*/
        [Inject] IAuthenticationService _authenticationService { get; set; }
        public string Message { get; private set; }
        CreateDoctorVM doctor { get; set; } = new CreateDoctorVM();

        async Task Createdoctor()
        {
            var response = await _client.CreateDoctor(doctor);
            var fullname = doctor.Name + " " +doctor.Surname;
            var email = doctor.Email;
            var password = doctor.Password;
            var confirmPassword = doctor.Password;
            var registrationNumber = doctor.RegistrationNumber;
            var register = _authenticationService.RegisterAsync(fullname,email,password,confirmPassword,registrationNumber,"doctor"); 
            /*if (response.Success)
            {
                toastService.ShowSuccess("Leave Type created Successfully");
                toastService.ShowToast(ToastLevel.Info, "Test");
                _navManager.NavigateTo("/doctors/");
            }
            Message = response.Message;*/
        }

    }
}