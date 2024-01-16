using PMRU.BlazorUI.Models;

namespace PMRU.BlazorUI.Contracts
{
    public interface IDoctorServise
    {
        Task<List<DoctorVM>> GetDoctors();
        Task<DoctorVM> GetDoctorsById(int id);
    }
}

