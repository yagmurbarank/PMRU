using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Services.Base;
using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Contracts
{
    public interface IAvailabilityService
    {
        Task<List<AvailabilityVM>> GetAvailabilities();
        Task<List<AvailabilityVM>> GetAvailabilitiesByDoctorId(int doctorId);

        Task<Response<Guid>> CreateAvailability(AvailabilityVM vm);
        Task<Response<Guid>> CreateAvailabilities(List<AvailabilityVM> vm);
        Task<Response<Guid>> DeleteAvailability(int id);
        Task<Response<Guid>> DeleteAvailabilities(List<int> ids);
        Task<Response<Guid>> UpdateAvailability(AvailabilityVM vm);

    }
}
