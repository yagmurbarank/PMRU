using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Models;

namespace PMRU.BlazorUI.Contracts
{
    public interface IAppointmentService
    {
        Task<List<AppointmentVM>> GetDoctorAppointments();
        Task<AppointmentVM> GetAppoitmentsByDoctorId(int doctorId);
    }
}
