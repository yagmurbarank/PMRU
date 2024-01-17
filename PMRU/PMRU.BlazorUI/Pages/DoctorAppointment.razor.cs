using Microsoft.AspNetCore.Components;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Appointment;
using PMRU.BlazorUI.Models.Doctor;


namespace PMRU.BlazorUI.Pages
{
    public partial class DoctorAppointment
    {
        [Inject]
        public IAppointmentService appointmentService { get; set; }
        [Inject]
        public IDoctorService doctorService { get; set; }

        private List<AppointmentVM> appointments { get; set; }
        public DoctorVM Doctor { get; private set; } = new DoctorVM();
        private int doctorId;
        protected override async Task OnInitializedAsync()
        {
           
            appointments = await appointmentService.GetAppointmentsByDoctorId(doctorId);
        }
      

        private async Task GetAppointmentsByDoctorId()
        {
            appointments = await appointmentService.GetAppointmentsByDoctorId(doctorId);
        }
    }
}
