using PMRU.BlazorUI.Models.Doctor;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Contracts
{
    public interface IDoctorService
    {
        Task<List<DoctorVM>> GetDoctors();
        Task<DoctorVM> GetDoctorById(int id);
        Task<DoctorVM> GetDoctorByRegistrationNumber(string registrationNumber);
        Task<List<DoctorVM>> GetDoctorsByLocation(int locationid);

        Task <Response<Guid>> CreateDoctor (CreateDoctorVM doctorVM);
        Task<Response<Guid>> UpdateDoctor (UpdateDoctorVM doctorVM);
        Task<Response<Guid>> DeleteDoctor (DeleteDoctorVM doctorVM);
    }
}

