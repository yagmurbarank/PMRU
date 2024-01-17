using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Contracts
{
    public interface IDoctorService
    {
        Task<List<DoctorVM>> GetDoctors();
        Task<DoctorVM> GetDoctorById(int id);
        Task<IList<DoctorVM>> GetDoctorsByLocation(int locationid);

        Task <Response<int>> CreateDoctor (CreateDoctorVM doctorVM);
        Task<Response<Guid>> UpdateDoctor (DoctorVM doctorVM);
        Task<Response<Guid>> DeleteDoctor (int id);
    }
}

