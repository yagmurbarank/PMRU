using PMRU.BlazorUI.Models.Appointment;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Contracts
{
    public interface IAppointmentService
    {
        Task<List<AppointmentVM>> GetAppointments();
        Task<List<AppointmentVM>> GetAppointmentsByDoctorId(int doctorId);
        Task<AppointmentVM> GetAppointmentByEmployeeId(int employeeId);
        Task<List<AppointmentVM>> GetAppointmentsByDate(DateOnly date);

        Task<Response<Guid>> CreateAppointment(CreateAppointmentVM appointmentVM);
        Task<Response<Guid>> DeleteAppointment(DeleteAppointmentVM appointmentVM);
        Task<Response<Guid>> UpdateAppointment(UpdateAppointmentVM appointmentVM);

    }
}
