using Microsoft.AspNetCore.Components;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Models.Appointment;
using PMRU.BlazorUI.Services;

namespace PMRU.BlazorUI.Pages
{
    public partial class ReportPage
    {
        [Inject]
        IAppointmentService appointmentService { get; set; }

        private DateOnly selectedDate;
        private List<AppointmentVM> reportResult;
        private string doctorFilter = "";
        private List<AppointmentVM> filteredReportResult;


        protected override void OnInitialized()
        {
            selectedDate = DateOnly.FromDateTime(DateTime.Now);
        }

        private async Task ReceiveReport()
        {
            reportResult = await appointmentService.GetAppointmentsByDate(selectedDate);

            if (!string.IsNullOrWhiteSpace(doctorFilter))
            {
                filteredReportResult = reportResult
                    .Where(r => r.Doctor.Name.ToLower().Contains(doctorFilter.ToLower()) || r.Doctor.Surname.ToLower().Contains(doctorFilter.ToLower()))
                    .ToList();
            }
            else
            {
                filteredReportResult = reportResult;
            }
        }
    }
}