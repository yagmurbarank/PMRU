using PMRU.BlazorUI.Models;

namespace PMRU.BlazorUI.Contracts
{
    public interface IDoctorService
    {
        Task<List<DoctorVM>> GetDoctors();
        Task<DoctorVM> GetDoctorById(int id);
        Task<IList<DoctorVM>> GetDoctorsByLocation(int locationid);
    }
}

