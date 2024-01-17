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
        public string Message { get; private set; }
        CreateDoctorVM doctor { get; set; } = new CreateDoctorVM();

        async Task Createdoctor()
        {
            var response = await _client.CreateDoctor(doctor);
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