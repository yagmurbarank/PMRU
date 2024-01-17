using Microsoft.AspNetCore.Components;
using PMRU.BlazorUI.Models.Doctor;

namespace PMRU.BlazorUI.Pages.Doctors
{
    public partial class FormComponent
    {
        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public CreateDoctorVM Doctor { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}