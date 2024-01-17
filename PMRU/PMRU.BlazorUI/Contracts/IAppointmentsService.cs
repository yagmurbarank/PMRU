using PMRU.BlazorUI.Models.Appointment;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Contracts
{
    public interface IAppointmentService
    {
        Task<List<AppointmentVM>> GetAppointments();
        Task<List<AppointmentVM>> GetAppoitmentsByDoctorId(int doctorId);
        Task<AppointmentVM> GetAppointmentByEmployeeId(int employeeId);
        Task<List<AppointmentVM>> GetAppoitmentsByDate(DateOnly date);

        Task<Response<Guid>> CreateAppointment(CreateAppointmentVM appointmentVM);
        Task<Response<Guid>> DeleteAppointment(DeleteAppointmentVM appointmentVM);
        Task<Response<Guid>> UpdateAppointment(UpdateAppointmentVM appointmentVM);

    }
}
