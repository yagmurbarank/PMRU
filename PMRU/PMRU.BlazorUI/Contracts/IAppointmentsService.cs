using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Contracts
{
    public interface IAppointmentService
    {
        Task<List<AppointmentVM>> GetAppointments();
        Task<List<AppointmentVM>> GetAppoitmentsByDoctorId(int doctorId);
        Task<List<AppointmentVM>> GetAppoitmentsByDate(DateOnly date);

        Task<Response<Guid>> CreateAppointment(AppointmentVM appointmentVM);
        Task<Response<Guid>> DeleteAppointment(int id);
        Task<Response<Guid>> UpdateAppointment(AppointmentVM appointmentVM);

    }
}
