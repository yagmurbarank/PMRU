using Microsoft.AspNetCore.Components;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Doctor;
using PMRU.BlazorUI.Services;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Pages.Doctors
{
    public partial class Index
    {
        [Inject]
        public IDoctorService DoctorService { get; set; }

        public List<DoctorVM> doctors;
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        
        protected void CreateDoctor()
        {
            NavigationManager.NavigateTo("/doctors/create");
        }
        protected async override Task OnInitializedAsync()
        {
            doctors = await DoctorService.GetDoctors();
        }
    }
}
